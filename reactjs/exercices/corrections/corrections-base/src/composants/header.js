// export function Header() {
//     return(
//         <header>
//             <h1>Header de la page</h1>
//         </header>
//     )
// }

// export const Header = () => {
//     return(
//         <header>
//             <h1>Header de la page</h1>
//         </header>
//     )
// }

export class Header extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <header>
                <h1>Header de la page</h1>
            </header>
        );
    }
}
;