import { ProductButton } from "./product-button"

export const Cart = (props) =>{
    let total = 0
    props.cart.map(p => total += p.price)
    return(
        <div>
            <h1>Panier</h1>
            {props.cart.map((p, i) => 
                (
                    <div key={i}>{p.title}<ProductButton  id={p.id} removeFromCart={props.removeFromCart} addToCart={props.addToCart} isInCart={props.isInCart}></ProductButton></div>
                )
            )}
            <div>{total}€</div>
        </div>
    )
}