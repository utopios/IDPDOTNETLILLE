import {Component} from "react"
import DetailPersonne from "./detail-personne"
class FormPersonne extends Component {
    constructor(props) {
        super(props);
        this.state = {
            nom : undefined,
            prenom : undefined
        }
    }

    changeInputNom = (e) => {
        this.setState({
            nom: e.target.value
        })
    }

    changeInputPrenom = (e) => {
        this.setState({
            prenom: e.target.value
        })
    }
    
    validForm = (e) => {
        e.preventDefault()
        this.props.update({...this.state})
    }
    render() { 
        return ( 
            <form onSubmit={this.validForm}>
                <div>
                    <input type="text" placeholder="Nom " onChange={this.changeInputNom} />
                </div>
                
                <div>
                    <input type="text" placeholder="Prénom " onChange={this.changeInputPrenom} />
                </div>
                {/* <div>
                    {this.state.nom} {this.state.prenom}
                </div> */}
                <div>
                    <button type='submit'>Valider</button>
                </div>
                {/* <DetailPersonne nom={this.state.nom} prenom={this.state.prenom}/> */}
            </form>
         );
    }
}
 
export default FormPersonne;