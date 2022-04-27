import { Customer } from "../classes/customer.js"
import {readFileSync, writeFileSync} from "fs"
export class CustomerService {
    constructor() {
        this.file = "data/clients.json"
        this.customers = []
        this.count = 0
    }

    readFromJson() {
        const data = readFileSync(this.file).toString()
        this.customers = JSON.parse(data)
        this.count = this.customers.length > 0 ? this.customers[this.customers.length-1].id : 0
    }

    writeToJson() {
        writeFileSync(this.file, JSON.stringify(this.customers))
    }

    addCustomer(firstName, lastName, phone) {
        const customer = new Customer(++this.count, firstName, lastName, phone)
        this.customers.push(customer)
        this.writeToJson()
    }

    getCustomerById(id) {
        
        return this.customers.find(c =>c.id == id)
    }
    getAllCustomers() {
        return this.customers
    }
}