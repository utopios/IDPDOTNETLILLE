import { OrderProduct } from "../interfaces/order-product.interface"
import { Customer } from "./customer"


export class Order {
    id:number
    customer:Customer
    products:Array<OrderProduct> = []
    constructor(id:number, customer:Customer, products:Array<OrderProduct>) {
        this.id = id
        this.customer = customer
        this.products = products
    }
}