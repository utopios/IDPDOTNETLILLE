
import React, { Component } from "react";
import Imcs from "../Components/Imcs/Imcs";
import "../index.css";


class Affichage extends Component {
  constructor(props) {
    super(props);
    this.state = {};
  }

  render() {
    return (
      <div className="col-10 affichage">
          <Imcs imc={this.props.listImcCal} ></Imcs>

      </div>
    );
  }
}
export default Affichage;