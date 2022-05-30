import Imc from "../Imc/Imc";
import React, {Component} from "react";

class Imcs extends Component{
constructor(props){
  super (props) 
this.state = {}
}

render (){
  return (
    <div className="row" id="listImc">
      {this.props.imc.map((element, index) => (
          <Imc imc={element} key={index}></Imc>
        ))}


    </div>
  );
};
}
export default Imcs;
