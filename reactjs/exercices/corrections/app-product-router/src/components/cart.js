import { ProductButton } from "./product-button"

export const Cart = (props) => {

    let total = props.cart.map(p => p.price).reduce((p1, p2) => p1 + p2 ,0)

    return (
        <div>
            <h1>Panier</h1>
            {props.cart.map((p, i) =>
            (
                <div key={i}>{p.title}<ProductButton id={p.id} removeFromCart={props.removeFromCart} addToCart={props.addToCart} isInCart={props.isInCart}></ProductButton></div>
            )
            )}
            <div>{total}€</div>
        </div>
    )
}