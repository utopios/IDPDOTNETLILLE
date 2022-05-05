import {Route, Routes} from "react-router-dom"
import { Cart } from "./cart"
import { ProductDetail } from "./product-detail"
import { ProductList } from "./product-list"
export const ProductRouter = (props) => {

    return (
        <Routes>
            <Route path="/" element={<ProductList products={props.products} removeFromCart={props.removeFromCart} ></ProductList>}></Route>
            <Route  path="/cart" element={<Cart cart={props.cart} removeFromCart={props.removeFromCart} isInCart={props.isInCart} />}></Route>
            <Route path="/product/:id" element={<ProductDetail findProduct={props.findProduct} removeFromCart={props.removeFromCart} addToCart={props.addToCart} isInCart={props.isInCart} />}></Route>
        </Routes>
    )
}