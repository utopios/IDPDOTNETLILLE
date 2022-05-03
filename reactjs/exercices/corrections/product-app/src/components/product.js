import { ProductButton } from "./product-button"

export const Product = (props) => {
    const {urlImage, title, price , id} = props.product
    return(
        <div>
            <div><img src={urlImage} /></div>
            <div>{title}</div>
            <div>{price} €</div>
            <ProductButton id={id} isInCart={props.isInCart} removeFromCart={props.removeFromCart} addToCart={props.addToCart}></ProductButton>
            {/* <ProductButton {...props}></ProductButton> */}
        </div>
    )
}