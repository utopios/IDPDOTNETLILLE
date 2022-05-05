import {Component} from "react"
import { CartCount } from "./cart-count"
import { ProductList } from "./product-list"
import {BrowserRouter} from "react-router-dom"
import { ProductRouter } from "./product-router"
import { ProductMenu } from "./product-menu"
export class ProductApp extends Component {
    constructor(props) {
        super(props)
        this.state = {
            products : [
                {id:1, title: 'product 1', urlImage: '', price : 10},
                {id:2, title: 'product 2', urlImage: '', price : 20},
                {id:3, title: 'product 3', urlImage: '', price : 30},
            ],
            cart : []
        }
    }

    findProduct = (id) => {
        
        return this.state.products.find(p => p.id == id)
    }
    addToCart = (id) => {
        const product = this.state.products.find(p => p.id == id)
        if(product != undefined) {
            this.setState({cart : [...this.state.cart, {...product}]})
        }
    }
    isInCart = (id) => {
        return this.state.cart.find(p => p.id == id) != undefined
    }
    removeFromCart = (id) => {
        const newCart = this.state.cart.filter(p => p.id != id)
        this.setState({ cart: [...newCart]  });
    }
    render() {
        return(
            <BrowserRouter>
            <ProductMenu totalProduct={this.state.cart.length}/>      
            <ProductRouter products={this.state.products} removeFromCart={this.removeFromCart} addToCart={this.addToCart} findProduct={this.findProduct} isInCart={this.isInCart} />
                
            </BrowserRouter>
        )
    }
}