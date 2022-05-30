import React, { Component, useReducer } from "react";
import NavSide from "../Components/Navside";
import Affichage from "../Containers/Affichage";
import "../index.css"
import { LocalService } from "../services/LocalService";
import { get } from "../services/ApiService";

class Home extends Component {
  constructor(props) {
    super(props);
    this.state = {
      userActuel: undefined,
      listImcBrut: [],
      listImcFinal: []
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
      this.modificationTableauSemaine();
    });
  };

  modificationTableauSemaine = () => {
    const tabSem = [];
    const tab = this.state.listImcBrut;
    console.log(tab);
    const tableau = tab.reverse();
    if (tableau.length > 6) {
      for (let i = 0; i < 7; i++) {
        let jour = tableau[i];
        tabSem.push(jour);
      }
      this.setState({
        listImcFinal: tabSem
      });
    } else {
      this.setState({
        listImcFinal: tableau
      });
    }
  };

  render() {
    return (
      <div className="container-fluid home">
        <NavSide className="col-3"></NavSide>
        <Affichage
          className="col-9"
          listImcCal={this.state.listImcFinal}
        ></Affichage>
      </div>
    );
  }
}
export default Home;
