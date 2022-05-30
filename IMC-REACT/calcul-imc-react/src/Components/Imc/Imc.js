import React, { Component } from "react";
import "../../index.css";
import "./Imc.css";

class Imc extends Component {
  constructor(props) {
    super(props);
    this.state = {
      color: undefined
    };
  }

  componentDidMount() {
    console.log(this.props.imc.etat)
    let color;
    if (this.props.imc.etat == "Maigreur") {
      color = "grey";
    } else if (this.props.imc.etat == "Normal") {
      color = "green";
    } else if (this.props.imc.etat == "Surpoids") {
      color = "orange";
    } else if (this.props.imc.etat == "Obésité") {
      color = "Red";
    } else if (this.props.imc.etat == "O.Morbide") {
      color = "black";
    }
    this.setState({
      color: color
    });
  }

  render() {
  console.log(this.props.imc.nom)

    return (
      <div class="card user-card" id="card-bloc">
        <div class="card-header">
          <span>Indice</span>
          <div className="indice">{this.props.imc.indice}</div>
        </div>
        <div class="card-block">
          <h6 class="f-w-600 m-t-25 m-b-10">{this.props.imc.date}</h6>
          <div>
            <ul class="list-unstyled activity-leval" >
              <li 
                class={this.props.imc.taille.taille}
                style={{
                  backgroundColor: (this.props.imc.taille.taille == "active"
                    ? this.state.color
                    : "white")
                }}
              ></li>
              <li 
                class={this.props.imc.taille.taille1}
                style={{
                  backgroundColor: (this.props.imc.taille.taille1 == "active"
                    ? this.state.color
                    : "white")
                }}
              ></li>
              <li
                class={this.props.imc.taille.taille2}
                style={{
                  backgroundColor: (this.props.imc.taille.taille2 == "active"
                    ? this.state.color
                    : "white")
                }}
              ></li>
              <li
                class={this.props.imc.taille.taille3}
                style={{
                  backgroundColor: (this.props.imc.taille.taille3 == "active"
                    ? this.state.color
                    : "white")
                }}
              ></li>
              <li
                class={this.props.imc.taille.taille4}
                style={{
                  backgroundColor: (this.props.imc.taille.taille4 == "active"
                    ? this.state.color
                    : "white")
                }}
              ></li>
            </ul>
            <div class={this.props.imc.color}>
              <div class="row m-0 bloc" counter-block m-t-10 p-15 >
                <div class="col-4 p-0" id="bloc1">
                  <i class="fa fa-user" aria-hidden="true"></i>
                  <div >{this.props.imc.poids}</div>
                </div>
                <div class="col-4 p-0" id="bloc2">
                  <i class="fa fa-check-square-o" aria-hidden="true"></i>
                  <div className="etat">{this.props.imc.etat}</div>
                </div>
                <div class="col-4 p-0" id="bloc3">
                  <i class="fa fa-bar-chart" aria-hidden="true"></i>
                  <div>{this.props.imc.effort}</div>
                </div>
              </div>
            </div>
            <p class="m-t-15 text-muted">{this.props.imc.description}</p>
          </div>
        </div>
      </div>
    );
  }
}
export default Imc;


