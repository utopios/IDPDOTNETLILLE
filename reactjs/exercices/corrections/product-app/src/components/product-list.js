import { Product } from "./product"

export const ProductList = (props) => {
    return(
        <div>
            {props.products.map((p,i) => (<Product product={p} key={i} isInCart={props.isInCart} removeFromCart={props.removeFromCart} addToCart={props.addToCart}></Product>))}
        </div>
    )
}