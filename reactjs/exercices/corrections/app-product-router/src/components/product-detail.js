import { withRouter } from "../hoc/withRouter"
import { ProductButton } from "./product-button"

export const ProductDetail = withRouter((props) => {
    const id = props.params.id
    const product = props.findProduct(id)
    return (
        <div>
        {
            product == undefined ?
            (
                <div>
                    aucun produit avec cet id
                </div>
            )
            :
            (
                <div>
                    Detail Produit
                    {product.title}<br/>
                    {product.price}<br/>
                    <ProductButton removeFromCart={props.removeFromCart} addToCart={props.addToCart} isInCart={props.isInCart}></ProductButton>
                </div>
            )
        }
        </div>
)
})