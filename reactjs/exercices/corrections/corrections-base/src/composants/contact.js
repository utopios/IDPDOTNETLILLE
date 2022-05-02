// import {Component} from "react"
// export class Contact extends Component {
//     constructor(props) {
//         super(props)
//     }

//     render() {
//         const {nom, prenom, telephone, email} = this.props.contact
//         return(
//             <div>
//                 Nom : {nom}, Prénom : {prenom}, Téléphone : {telephone}, email: {email}
//             </div>
//         )
//     }
// }

export const Contact = (props) => {
    const { nom, prenom, telephone, email } = props.contact
    return (
        <div>
            Nom : {nom}, Prénom : {prenom}, Téléphone : {telephone}, email: {email}
        </div>
    )
}