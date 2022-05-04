import { Link } from "react-router-dom"

export const MenuTodo = (props) => {

    return(
        <header>
            <nav>
                <Link to='/'>Accueil</Link>
                <Link to="/formulaire">Ajouter une Todo</Link>
            </nav>
        </header>
    )
}