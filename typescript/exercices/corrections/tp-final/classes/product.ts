import { BaseClass } from "./base"

export class Product extends BaseClass {
    title:string
    price:number
    stock:number
    constructor(id:number, title:string, price:number, stock:number) {
        super(id)
        this.id = id
        this.title = title
        this.price = price,
        this.stock = stock
    }
}