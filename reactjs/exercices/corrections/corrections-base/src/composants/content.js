// export function Content() {
//     return(
//         <main>
//             <h2>contenu de la page</h2>
//         </main>
//     )
// }

// const Content = () => {
//     return(
//         <main>
//             <h2>Contenu de la page</h2>
//         </main>
//     )
// }

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