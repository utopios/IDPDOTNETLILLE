import {Component} from "react"
class DetailPersonne extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <div>
                    Resultat Nom: {this.props.nom}
                </div>
                <div>
                    Resultat Prénom: {this.props.prenom}
                </div>
            </div>
        );
    }
}

export default DetailPersonne;