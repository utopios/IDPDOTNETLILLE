import React, { Component } from "react";
import { Table, Space, Button } from "antd";
import "../index.css";
import { LocalService } from "../services/LocalService";
import { get } from "../services/ApiService";
import NavSide from "../Components/Navside";
import createG2 from "g2-react";
import { Modal } from "antd";
import history from "../history";

import { LoadingOutlined } from '@ant-design/icons';


const antIcon = <LoadingOutlined style={{ fontSize: 24 }} spin />;

const Line = createG2(chart => {
  chart
    .line()
    .position("date*indice")
    .color("#4FAAEB")
    .shape("circle")
    .size(2);
  chart.render();
});
const { Column } = Table;

class AffichageMois extends Component {
  constructor(props) {
    super(props);
    this.state = {
      userActuel: undefined,
      listImcBrut: [],
      listImcFinal: [],
      data: [],
      width: 500,
      height: 600,
      plotCfg: {
        margin: [100, 80, 100, 70]
      },
      etatColor: undefined,
      visible: undefined,
      key: undefined
    };
  }

  componentDidMount() {
    const user = JSON.parse(localStorage.getItem('user'));
    const userNom = user.nom;
    this.setState({
      userActuel: userNom
    });
    this.appelList(user.nom);
  }

  appelList = user => {
    get("listImcUser/" + user).then(res => {
      this.setState({
        listImcBrut: res.data
      });
      this.modificationTableauMois();
    });
  };

  modificationTableauMois = () => {
    const tabMois = [];
    const tab = this.state.listImcBrut;
    console.log(tab);
    const tableau = tab.reverse();
    if (tableau.length > 29) {
      for (let i = 0; i < 30; i++) {
        let jour = tableau[i];
        tabMois.push(jour);
      }
      this.setState({
        listImcFinal: tabMois
      });
    } else {
      this.setState({
        listImcFinal: tableau
      });
    }
    this.creationGraph();
  };
  
  creationGraph = () => {
    let dataIndice = [];
    const inverseTab = this.state.listImcFinal.reverse();
    for (let element of inverseTab) {
      let dataElement = {
        date: element.date,
        indice: element.indice
      };
      dataIndice.push(dataElement);
    }
    this.setState({
      data: dataIndice
    });
  };

  delete = (key, e) => {
    e.preventDefault();
    this.setState({
      key: key
    });
    this.showModal();
  };
  countDown() {
    let secondsToGo = 2;
    const modal = Modal.success({
      title: "Suppression",
      content: `Votre donnée a bien été supprimée`
    });
    const timer = setInterval(() => {
      secondsToGo -= 1;
    }, 1000);
    setTimeout(() => {
      clearInterval(timer);
      modal.destroy();
      history.push("/Home");
    }, secondsToGo * 1000);
  }

  showModal = e => {
    this.setState({
      visible: true
    });
  };
  handleOk = e => {
    get("delete-imc/" + this.state.userActuel + "/" + this.state.key).then(
      res => {
        const response = res.data;
        console.log(response);
        if (response.isDelete == true) {
          this.countDown();
        }
      }
    );
    this.setState({
      visible: false
    });
  };
  handleCancel = e => {
    this.setState({
      visible: false
    });
  };

  render() {
    return (
      <div className="home">
        <Modal
          title="Message"
          visible={this.state.visible}
          onOk={this.handleOk}
          onCancel={this.handleCancel}
        >
          <p>Voulez-vous supprimer cette donnée?</p>
        </Modal>
        <NavSide></NavSide>
      
        <div className="container-fluid form">
          <div className="row">
            <div className="col-6 mr-10">
              <div className="row m-t-10">
                <Table dataSource={this.state.listImcFinal}>
                  <Column title="Date" dataIndex="date" key="date" />
                  <Column title="Poids" dataIndex="poids" key="poids" />
                  <Column title="Indice" dataIndex="indice" key="indice" />
                  <Column
                    class="orange"
                    title="Etat"
                    dataIndex="etat"
                    key="etat"
                  />
                  <Column
                    title="Action"
                    key="action"
                    render={(text, record) => (
                      <Space size="middle">
                        <Button
                          type="primary"
                          shape="round"
                          onClick={e => {
                            this.delete(record.date, e);
                          }}
                        >
                          Delete
                        </Button>
                      </Space>
                    )}
                  />
                </Table>
              </div>
            </div>
            <div className="col-6">
              <Line
                data={this.state.data}
                width={this.state.width}
                height={this.state.height}
                plotCfg={this.state.plotCfg}
              ></Line>
            </div>
          </div>
        </div>
      </div>
    );
  }
}
export default AffichageMois;
