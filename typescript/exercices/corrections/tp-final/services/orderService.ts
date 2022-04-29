import { Customer } from "../classes/customer"
import { Order } from "../classes/order"
import { Product } from "../classes/product"
import { CreateOrderProduct } from "../interfaces/create-order-product.interface"
import { OrderProduct } from "../interfaces/order-product.interface"
import { BaseService } from "./baseService"
import { CustomerService } from "./customerService"
import { ProductService } from "./productService"



export class OrderService extends BaseService<Order> {
    customerService:CustomerService
    productService:ProductService
    constructor(customerService:CustomerService, productService:ProductService) {
        super("data/commandes.json")

        this.customerService = customerService
        this.productService = productService
    }

    addOrder(customerId:number, products:Array<CreateOrderProduct>):boolean {
        const customer:Customer = this.customerService.getCustomerById(customerId)
        
        if(customer != undefined) {
            const orderProducts:Array<OrderProduct> = []
            products.forEach(p => {
                const product:Product = this.productService.getProductById(p.id)
                if(product != undefined && product.stock > p.qty) {
                    orderProducts.push({product: product, qty: p.qty})
                    this.productService.updateProductStockById(p.id, p.qty)
                }
            });
            const order:Order = new Order(++this.count,customer, orderProducts)
            this.data.push(order)
            this.writeToJson()
            return true
        }
        return false
    }

    getOrderById(id:number):Order {
        return this.data.find(o => o.id == id)
    }

    getAllOrders():Array<Order> {
        return this.data
    }
}