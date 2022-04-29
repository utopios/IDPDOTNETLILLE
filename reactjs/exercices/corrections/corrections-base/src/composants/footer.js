// export function Footer() {
//     return(
//         <footer>
//             <h3>Je suis le footer</h3>
//         </footer>
//     )
// }

// export const Footer = () => {
//     return(
//         <footer>
//             <h3>Je suis le footer</h3>
//         </footer>
//     )
// }
import {Component} from "react"
export class Footer extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <footer>
                <h3>Je suis le footer</h3>
            </footer>
        );
    }
}
