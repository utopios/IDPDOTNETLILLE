import DetailPersonne from "./detail-personne";
import FormPersonne from "./form-personne";
import {Component} from "react"
import { ListPersonnes } from "./list-personnes";
class Personne extends Component {
    constructor(props) {
        super(props);
        this.state = {
            nom: undefined,
            prenom: undefined,
            personnes:[]
        }
    }

    //Mettre à jour les champs un par un
    // update = (val, key) => {
    //     const tmpState = {...this.state}
    //     tmpState[key] = val
    //     this.setState({...tmpState})
    // }

    update = (obj) => {
        // this.setState({...obj})
        this.setState({
            personnes : [...this.state.personnes, {...obj}]
        })
    }
    render() { 
        return ( <div>
            <FormPersonne update={this.update}/>
            {/* <DetailPersonne nom={this.state.nom} prenom={this.state.prenom}/> */}
            <ListPersonnes personnes={this.state.personnes} />
        </div> );
    }
}
 
export default Personne;