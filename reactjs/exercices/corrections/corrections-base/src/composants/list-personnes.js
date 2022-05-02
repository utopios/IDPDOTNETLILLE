import {Component} from "react"
import DetailPersonne from "./detail-personne"

export class ListPersonnes extends Component {
    constructor(props) {
        super(props)
    }

    render() {
        return(
            <div>
                {this.props.personnes.map((p,i) => (<DetailPersonne key={i} nom={p.nom} prenom={p.prenom} />))}
            </div>
        )
    }
}