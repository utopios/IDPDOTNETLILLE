export class Product {
    id:number
    title:string
    price:number
    stock:number
    constructor(id:number, title:string, price:number, stock:number) {
        this.id = id
        this.title = title
        this.price = price,
        this.stock = stock
    }
}