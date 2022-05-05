import { Link } from "react-router-dom"
import { CartCount } from "./cart-count"

export const ProductMenu = (props) => {
    return(
        <div>
            <Link to="/">Accueil</Link>
            <Link to="cart">Panier</Link>
            <CartCount totalProduct={props.totalProduct}></CartCount>
        </div>
    )
}