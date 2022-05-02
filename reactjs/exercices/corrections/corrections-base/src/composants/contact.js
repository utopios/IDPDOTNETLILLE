import {Component} from "react"
export class Contact extends Component {
    constructor(props) {
        super(props)
    }

    render() {
        const {nom, prenom, telephone, email} = this.props
        return(
            <div>
                Nom : {nom}, Prénom : {prenom}, Téléphone : {telephone}, email: {email}
            </div>
        )
    }
}