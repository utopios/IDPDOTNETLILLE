import React, { useState } from "react";
import { Form, Input, Button } from "antd";
import { useHistory } from "react-router-dom";
import { Link } from "react-router-dom";
import "../index.css";
import { post } from "../services/ApiService";
import { LocalService } from "../services/LocalService";
import { Modal } from "antd";

const Identification = props => {
  const [nom, setNom] = useState();
  const [password, setWord] = useState();
  const [visible, setVisible] = useState();
  const history = useHistory();

  const validateMessages = {
    required: "${label} is required!",
    types: {
      email: "${label} is not validate email!",
      number: "${label} is not a validate number!"
    },
    number: {
      range: "${label} must be between ${min} and ${max}"
    }
  };

  const layout = {
    labelCol: {
      span: 8
    },
    wrapperCol: {
      span: 16
    }
  };

  const showModal = () => {
    setVisible(true);
  };

  const handleOk = e => {
    history.push("/Home");
    setVisible(false);
  };

  const handleCancel = e => {
    setVisible(false);
  };

  const submit = () => {
    const user = {
      nom: nom,
      mdp: password
    };

    post("identification", user).then(res => {
      const response = res.data;

      if (response.msg === "connexion valide") {
        if(localStorage.getItem("user") === null){
          console.log(user)
          localStorage.setItem('user', JSON.stringify(user));
        }
        showModal();
      } else if (response.msg === "identifiant non trouvé") {
        countDown();
      } else if (response.msg === "erreur mdp") {
        countDown2();
      }
    });
  };
  function countDown() {
    let secondsToGo = 5;
    const modal = Modal.error({
      title: "Erreur",
      content: `L'identifiant est introuvable`
    });
    const timer = setInterval(() => {
      secondsToGo -= 1;
      modal.update({
        content: `Erreur de saisie ou vous n'êtes pas encore inscrit.
        ${secondsToGo} second.`
      });
    }, 1000);
    setTimeout(() => {
      clearInterval(timer);
      modal.destroy();
      history.push("");
    }, secondsToGo * 1000);
  }
  function countDown2() {
    let secondsToGo = 5;
    const modal = Modal.error({
      title: "Erreur",
      content: `Le mot de passe est incorrect`
    });
    const timer = setInterval(() => {
      secondsToGo -= 1;
      modal.update({
        content: `Veuillez le saisir à nouveau.
        ${secondsToGo} second.`
      });
    }, 1000);
    setTimeout(() => {
      clearInterval(timer);
      modal.destroy();
      history.push("");
    }, secondsToGo * 1000);
  }

  return (
    <div className="container identification">
      <h1>Identification</h1>
      <Modal
        title="Message"
        visible={visible}
        onOk={handleOk}
        onCancel={handleCancel}
      >
        <p>Identification reussie</p>
      </Modal>

      <Form {...layout} validateMessages={validateMessages}>
        <Form.Item
          name="nom"
          label="Name"
          rules={[
            {
              required: true
            }
          ]}
          onChange={e => setNom(e.target.value)}
        >
          <Input />
        </Form.Item>
        <Form.Item
          name="password"
          label="Password"
          rules={[
            {
              required: true
            }
          ]}
          onChange={e => setWord(e.target.value)}
        >
          <Input.Password />
        </Form.Item>

        <Form.Item wrapperCol={{ ...layout.wrapperCol, offset: 8 }}>
          <Button type="primary" htmlType="submit" onClick={submit}>
            Validation
          </Button>
          &nbsp; &nbsp; &nbsp;
          <span className="textCompte">
            Si vous ne disposez pas de compte? &nbsp; &nbsp;
            <Link to="Creation">Inscription</Link>
          </span>
        </Form.Item>
      </Form>
    </div>
  );
};
export default Identification;
