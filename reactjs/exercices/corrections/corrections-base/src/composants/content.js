// export function Content(props) {
//     return(
//         <main>
//             <h2>contenu de la page</h2>
//         </main>
//     )
// }

// const Content = (props) => {
//     return(
//         <main>
//             <h2>Contenu de la page</h2>
//         </main>
//     )
// }
import {Component} from "react"
export class Content extends Component {
    constructor(props) {
        super(props)
    }

    render() {
        return(
            <main>
            <h2>Contenu de la page</h2>
         </main>
        )
    }
}