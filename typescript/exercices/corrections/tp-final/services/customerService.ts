import { Customer } from "../classes/customer"
import {BaseService} from "./baseService"
export class CustomerService extends BaseService<Customer> {
    constructor() {
        super("data/clients.json")        
    }

    

    addCustomer(firstName:string, lastName:string, phone:string):void {
        const customer:Customer = new Customer(++this.count, firstName, lastName, phone)
        this.data.push(customer)
        this.writeToJson()
    }

    getCustomerById(id:number):Customer {
        
        return this.data.find(c =>c.id == id)
    }
    getAllCustomers():Array<Customer> {
        return this.data
    }
}