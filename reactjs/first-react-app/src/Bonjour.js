//=> Avec une fonction
// export function Bonjour() {
//     return(
//         <div>
//             <h1>Bonjour tout le monde</h1>
//         </div>
//     )
// }

import { Component } from "react";

//Avec une lambda
// export const Bonjour = () => {
//     return(
//         <div>
//             <h1>Bonjour tout le monde</h1>
//         </div>
//     )
// }

// export class Bonjour extends PureComponent {
export class Bonjour extends Component {
    constructor(props) {
        super(props)
    }

    render() {
        return(
            <div>
                <h1>Bonjour tout le monde</h1>
            </div>
        )
    }
}