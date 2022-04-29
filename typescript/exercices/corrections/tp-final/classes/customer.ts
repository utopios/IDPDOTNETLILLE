import { BaseClass } from "./base"

export class Customer extends BaseClass {
   
    firstName:string
    lastName:string
    phone:string
    constructor(id:number, firstName:string, lastName:string, phone:string) {
        super(id)
        this.firstName = firstName
        this.lastName = lastName
        this.phone = phone
    }
}