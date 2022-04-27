import {readFileSync, writeFileSync} from "fs"
import { Product } from "../classes/product.js"
export class ProductService {
    constructor() {
        this.count = 0
        this.products = []
        this.file = "data/produits.json"
    }

    readFromJson() {
        const data = readFileSync(this.file).toString()
        this.products = JSON.parse(data)
        this.count = this.products.length > 0 ? this.products[this.products.length-1].id : 0
    }

    writeToJson() {
        writeFileSync(this.file, JSON.stringify(this.products))
    }

    addProduct(title, price, stock) {
        const product = new Product(++this.count, title, price, stock)
        this.products.push(product)
        this.writeToJson()
    }

    getProductById(id) {
        return this.products.find(p => p.id == id)
    }

    updateProductStockById(id, deltaStock) {
        const product = this.getProductById(id)
        if(product != undefined) {
            product.stock -= deltaStock
            this.writeToJson()
            return true
        }
        return false
    }
}