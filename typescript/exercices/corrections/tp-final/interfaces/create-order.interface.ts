import { CreateOrderProduct } from "./create-order-product.interface";

export interface CreateOrder {
    products:Array<CreateOrderProduct>
    customerId:number
}