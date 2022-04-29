import { Product } from "../classes/product"
import { BaseService } from "./baseService"

export class ProductService extends BaseService<Product> {
    constructor() {
        super("data/produits.json")    
    }

    addProduct(title:string, price:number, stock:number):void {
        const product = new Product(++this.count, title, price, stock)
        this.data.push(product)
        this.writeToJson()
    }

    getProductById(id:number):Product {
        return this.data.find(p => p.id == id)
    }

    updateProductStockById(id:number, deltaStock:number):boolean {
        const product:Product = this.getProductById(id)
        if(product != undefined) {
            product.stock -= deltaStock
            this.writeToJson()
            return true
        }
        return false
    }
}