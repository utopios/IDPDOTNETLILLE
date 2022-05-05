export const ProductButton = (props) => {
    const {id, isInCart, addToCart, removeFromCart} = props

    const addToCartButton = (e) => {
        if(!isInCart(id)) {
            addToCart(id)
        }else {
            removeFromCart(id)
        }

    }
    return(
        <div>
            <button onClick={addToCartButton} >{isInCart(id) ? 'Remove From Cart' : 'Add To Cart'}</button>
        </div>
    )
}