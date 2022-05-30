import React, { useState } from "react";
import { Form, Input, InputNumber, Button } from "antd";
import { LocalService } from "../services/LocalService";
import { post } from "../services/ApiService";
import { useHistory } from "react-router-dom";
import { Modal } from "antd";
import { Link } from "react-router-dom";

const Creation = props => {
  const [nom, setNom] = useState();
  const [password, setWord] = useState();
  const [age, setAge] = useState();
  const [taille, setTaille] = useState();
  const [poids, setPoids] = useState();
  const [visible, setVisible] = useState();

  const history = useHistory();

  const validateMessages = {
    required: "${label} is required!",
    types: {
      number: "${label} is not a validate number!"
    },
    number: {
      range: "${label} doit être entre ${min} and ${max}"
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
      mdp: password,
      age: age,
      poids: poids,
      taille: taille
    };
    console.log(user);
    post("creation", user).then(res => {
      const response = res.data;
      console.log(response);
      if (response.msg == "user created") {
        showModal();
        if (localStorage.getItem("user") == null) {
          localStorage.setItem('user', JSON.stringify(user));
        }
      } else {
        countDown();
      }
    });
  };

  function countDown() {
    let secondsToGo = 5;
    const modal = Modal.success({
      title: "Redirection ",
      content: `Votre profil existe déjà`
    });
    const timer = setInterval(() => {
      secondsToGo -= 1;
      modal.update({
        content: `Vous allez être redirigé vers la page de connexion dans ${secondsToGo} second.`
      });
    }, 1000);
    setTimeout(() => {
      clearInterval(timer);
      modal.destroy();
      history.push("");
    }, secondsToGo * 1000);
  }

  const layout = {
    labelCol: {
      span: 8
    },
    wrapperCol: {
      span: 16
    }
  };

  return (
    <div className="container" id="creation">
      <Modal
        title="Message"
        visible={visible}
        onOk={handleOk}
        onCancel={handleCancel}
      >
        <p>Votre profil a bien été validé</p>
      </Modal>

      <h1>Inscription</h1>
      <Form
        {...layout}
        name="nest-messages"
        validateMessages={validateMessages}
      >
        <Form.Item
          name="nom"
          value={nom}
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
          name="pasword"
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
        <Form.Item
          name="age"
          label="Age"
          rules={[
            {
              type: "number",
              required: true,
              min: 0,
              max: 99
            }
          ]}
          onChange={e => setAge(e.target.value)}
        >
          <InputNumber />
        </Form.Item>
        <Form.Item
          name="taille"
          label="Taille"
          rules={[
            {
              type: "number",
              required: true
            }
          ]}
          onChange={e => setTaille(e.target.value)}
        >
          <InputNumber />
        </Form.Item>
        <Form.Item
          name="poids"
          label="Poids"
          rules={[
            {
              type: "number",
              required: true
            }
          ]}
          onChange={e => setPoids(e.target.value)}
        >
          <InputNumber />
        </Form.Item>
        <Form.Item wrapperCol={{ ...layout.wrapperCol, offset: 8 }}>
          <Button type="primary" htmlType="submit" onClick={submit}>
            Validation
          </Button>
          &nbsp; &nbsp; &nbsp;
          <span className="textCompte">
            Si vous disposez déjà d'un compte. &nbsp; &nbsp;
            <Link to="/">Connexion</Link>
          </span>
        </Form.Item>
      </Form>
    </div>
  );
};
export default Creation;
