import { Order } from "../classes/order.js"
import {readFileSync, writeFileSync} from "fs"
import { CustomerService } from "./customerService.js"
import { ProductService } from "./productService.js"
export class OrderService {
    constructor() {
        this.file = "data/commandes.json"
        this.orders = []
        this.count = 0
        this.customerService = new CustomerService()
        this.productService = new ProductService()
    }

    readFromJson() {
        const data = readFileSync(this.file).toString()
        this.orders = JSON.parse(data)
        this.count = this.orders.length > 0 ? this.orders[this.orders.length-1].id : 0
    }

    writeToJson() {
        writeFileSync(this.file, JSON.stringify(this.orders))
    }

    addOrder(cusotmerId, products) {
        const customer = this.customerService.getCustomerById(cusotmerId)
        if(customer != undefined) {
            const orderProducts = []
            products.forEach(p => {
                const product = this.productService.getProductById(p.id)
                if(product != undefined && product.stock > p.qty) {
                    orderProducts.push({product: product, qty: p.qty})
                    this.productService.updateProductStockById(p.id, p.qty)
                }
            });
            const order = new Order(++this.count,customer, orderProducts)
            this.orders.push(order)
            this.writeToJson()
            return true
        }
        return false
    }
}