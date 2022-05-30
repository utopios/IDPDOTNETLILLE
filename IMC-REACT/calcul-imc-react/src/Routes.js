import React, { Component } from "react";
import { Switch, Router, Route } from "react-router-dom";
import Creation from "./Containers/Creation";
import Identification from "./Containers/Identification";
import Home from "./Containers/Home";
import AffichageMois from "./Containers/Affichage-mois"
import AffichageTri from "./Containers/Affichage-tri"
import history from "./history";
import FormPoids from "./Containers/FormPoids";
export class Routes extends Component {
  constructor(props) {
    super(props);
    this.stat = {};
  }

  render() {
    return (
      <Router history={history}>
        <Switch>
          <Route path="/" exact>
            <Identification></Identification>
          </Route>
          <Route path="/Form">
            <FormPoids></FormPoids>
          </Route>
          <Route path="/Home">
            <Home></Home>
          </Route>
          <Route path="/Creation">
            <Creation></Creation>
          </Route>
          <Route path="/Tri">
            <AffichageTri></AffichageTri>
          </Route>
          <Route path="/Mois">
            <AffichageMois></AffichageMois>
          </Route>
        </Switch>
      </Router>
    );
  }
}
