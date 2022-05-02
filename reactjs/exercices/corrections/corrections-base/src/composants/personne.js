import DetailPersonne from "./detail-personne";
import FormPersonne from "./form-personne";
import {Component} from "react"
class Personne extends Component {
    constructor(props) {
        super(props);
        this.state = {
            nom: undefined,
            prenom: undefined,
        }
    }

    //Mettre à jour les champs un par un
    // update = (val, key) => {
    //     const tmpState = {...this.state}
    //     tmpState[key] = val
    //     this.setState({...tmpState})
    // }

    update = (obj) => {
        this.setState({...obj})
    }
    render() { 
        return ( <div>
            <FormPersonne update={this.update}/>
            <DetailPersonne nom={this.state.nom} prenom={this.state.prenom}/>
        </div> );
    }
}
 
export default Personne;