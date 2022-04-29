import { OrderProduct } from "../interfaces/order-product.interface"
import { BaseClass } from "./base"
import { Customer } from "./customer"


export class Order extends BaseClass {
    customer:Customer
    products:Array<OrderProduct> = []
    constructor(id:number, customer:Customer, products:Array<OrderProduct>) {
        super(id)
       
        this.customer = customer
        this.products = products
    }
}