//=> Avec une fonction
// export function Bonjour(props) {
//     return(
//         <div>
//             <h1>Bonjour {props.nom}</h1>
//         </div>
//     )
// }

import { Component } from "react";

//Avec une lambda
// export const Bonjour = (props) => {
//     return(
//         <div>
//             <h1>Bonjour {props.nom}</h1>
//         </div>
//     )
// }

// export class Bonjour extends PureComponent {
export class Bonjour extends Component {
    constructor(props) {
        super(props)
    }

    render() {
        return (
        
            <div>
                <h1>Bonjour {this.props.nom} {this.props.prenom} {this.props.age}</h1>
            </div>
        
        )
    }
}