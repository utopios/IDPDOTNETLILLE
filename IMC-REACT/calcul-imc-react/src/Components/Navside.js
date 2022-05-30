import React, { Component } from "react";
import "../index.css";
import { Button } from "antd";
import history from "../history";
import { LocalService } from "../services/LocalService";
import { get } from "../services/ApiService";
import { Modal } from "antd";
import { Link } from "react-router-dom";
import { Gauge } from "@antv/g2plot";

class Navside extends Component {
  constructor(props) {
    super(props);
    this.state = {
      userActuel: undefined,
      indiceActuel: undefined
    };
  }

  componentDidMount() {
    if (localStorage.getItem("user") != null) {
      console.log(localStorage.getItem("user"))
      const user = JSON.parse(localStorage.getItem('user'));
      const userNom = user.nom;
      this.setState({
        userActuel: userNom,
      });
      this.appelList(user.nom);
    }  
  }

  appelList = user => {
    get("listImcUser/" + user).then(res => {
      console.log(res.data);
      this.setState({
        listImcBrut: res.data
      });
      this.modificationTableauSemaine();
    });
  };

  modificationTableauSemaine = () => {
    const tab = this.state.listImcBrut;
    console.log(tab);
    const tableau = tab.reverse();
    let element = tableau[0];
    let indiceActuel = element.indice;
    this.setState({
      listImcFinal: tableau,
      indiceActuel: indiceActuel
    });
    this.creationJauge();
  };

  form = () => {
    history.push("/Form");
  };

  deconnexion = () => {
    this.setState({
      userActuel: undefined
    });
    this.countDown();
  };

  countDown() {
    let secondsToGo = 3;
    const modal = Modal.error({
      title: "Deconnexion",
      content: `Vous allez etre deconnecté`
    });
    const timer = setInterval(() => {
      secondsToGo -= 1;
      modal.update({
        content: `Deconnexion dans
        ${secondsToGo} seconds.`
      });
    }, 1000);
    setTimeout(() => {
      clearInterval(timer);
      modal.destroy();
      history.push("/");
    }, secondsToGo * 1000);
  }


  creationJauge = () => {
    const gaugePlot = new Gauge(document.getElementById("container"), {
      title: {
        visible: true,
        text: "IMC actuel"
      },
      width: 200,
      height: 200,
      value: this.state.indiceActuel,
      min: 0,
      max: 60,
      range: [0, 18, 25, 30, 40, 60],
      color: ["#85C1E9", "#82E0AA", "#F0B27A", "#E74C3C", "#273746"],
      statistic: {
        visible: true,
        text: "imc",
        color: "#30bf78"
      }
    });
    gaugePlot.render();
  };
  render() {
    return (
      <div
        imcs={this.props.listImcCal}
        className="col-2 container navside"
        id="navside"
      >
        <h1 class="row mb-10 mt-10">React Imc</h1>
        <div class="card mb-10" id="cardu">
          <div class="card-body">{this.state.userActuel}</div>
        </div>
        <div >
        </div>
        <div class="tab">
          <h6 class="row mb-3 pl-2">Periode des saisies</h6>
          <div class="col mb-10">
            <Link to="/Home">
              <li>
                <i class="fa fa-calendar-check-o mr-2" aria-hidden="true"></i>
                Semaine
              </li>
            </Link>
            <Link to="/Mois">
              <li>
                <i class="fa fa-calendar mr-2" aria-hidden="true"></i> Mois
              </li>
            </Link>
            <Link to="/Tri">
              <li>
                <i class="fa fa-calendar-plus-o mr-2" aria-hidden="true"></i>
                Trimestre
              </li>
            </Link>
          </div>
          <div class="but">
            <Button class="boutonPoids" type="primary" onClick={this.form}>
              Saisir son poids
            </Button>
            <Button
              class="boutonPoids"
              type="primary"
              onClick={this.deconnexion}
            >
              Deconnexion
            </Button>
          </div>
        </div>
        <div id="container"></div>
      </div>
    );
  }
}
export default Navside;
