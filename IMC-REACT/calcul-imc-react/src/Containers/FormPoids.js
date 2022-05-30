import React, { useState, useEffect } from "react";
import { get } from "../services/ApiService";
import { post } from "../services/ApiService";
import { LocalService } from "../services/LocalService";
import { Modal } from "antd";
import {
  Form,
  Input,
  Button,
  Radio,
  DatePicker,
} from "antd";
import Navside from "../Components/Navside";
import history from "../history";

const Formpoids = () => {
  const [componentSize, setComponentSize] = useState("default");
  const [date, setDate] = useState();
  const [poids, setPoids] = useState();
  const [visible, setVisible] = useState();
  const [listUser, setListuser] = useState();
  const [userActuel, setUserActuel] = useState();

  const [load, setLoad] = useState(true);

  const onFormLayoutChange = ({ size }) => {
    setComponentSize(size);
  };

  useEffect(() => {
    get("users").then(res => {
      setListuser(res.data);
    });
    const user = JSON.parse(localStorage.getItem('user'));
    const userNom = user.nom;
    setUserActuel(userNom);
  }, [load]);

  const success = () => {
    Modal.success({
      title: "Confirmation",
      content: (
        <div>
          <p>Votre poids a bien été enregistré</p>
        </div>
      ),
      onOk() {
        history.push("/Home");
      }
    });
  };

  const submit = () => {
    let userTrouve;
    for (let user1 of listUser) {
      console.log(user1)
      if (user1.nom == userActuel) {
        userTrouve = user1;
        const user = {
          nom: userTrouve.nom,
          mdp: userTrouve.mdp,
          date: date,
          poids: poids
        };
    
        post("form", user).then(res => {
          const response = res.data;
       
          if (response.msg == "poids enregistre") {
            success();
          } else {
            alert("ko");
          }
        });
      }
    }
  };
  return (
    <div className="home">
      <Navside></Navside>
      <div className="container-fluid form2">
        <Form
          labelCol={{
            span: 4
          }}
          wrapperCol={{
            span: 10
          }}
          layout="horizontal"
          initialValues={{
            size: componentSize
          }}
          onValuesChange={onFormLayoutChange}
          size={componentSize}
        >
          <Form.Item label="Format des champs" name="size">
            <Radio.Group>
              <Radio.Button value="small">Small</Radio.Button>
              <Radio.Button value="default">Default</Radio.Button>
              <Radio.Button value="large">Large</Radio.Button>
            </Radio.Group>
          </Form.Item>
          <Form.Item name="poids" label="Poids">
            <Input onChange={e => setPoids(e.target.value)} />
          </Form.Item>
          <Form.Item label="Date du jour">
            <DatePicker
              name="date"
              selected={date}
              onChange={date => setDate(date)}
            />
          </Form.Item>
          <Form.Item label="Validation">
            <Button type="primary" htmlType="submit" onClick={submit}>
              Validation
            </Button>
          </Form.Item>
        </Form>
      </div>
    </div>
  );
};
export default Formpoids;
