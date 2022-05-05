import { Link } from "react-router-dom"
import { withRouter } from "../hoc/withRouter"
import { ProductButton } from "./product-button"

export const Product = withRouter((props) => {
    const {urlImage, title, price , id} = props.product
    return(
        <div>
            <div><img src={urlImage} /></div>
            <div>{title}</div>
            <div>{price} €</div>
            {/* <ProductButton id={id} isInCart={props.isInCart} removeFromCart={props.removeFromCart} addToCart={props.addToCart}></ProductButton> */}
            <Link to={"/product/"+id}>Detail</Link>
            {/* <ProductButton {...props}></ProductButton> */}
        </div>
    )
})