import express,{Express, Request, Response} from "express"
import { Customer } from "./classes/customer"
import { Order } from "./classes/order"
import { Product } from "./classes/product"
import { CreateOrder } from "./interfaces/create-order.interface"
import { Id } from "./interfaces/id.interface"
import { Message } from "./interfaces/message.interface"
import { CustomerService } from "./services/customerService"
import { OrderService } from "./services/orderService"
import { ProductService } from "./services/productService"

const app:Express = express()

app.use(express.json())

//Création de services
const productService:ProductService = new ProductService()
const customerService:CustomerService = new CustomerService()
const orderService:OrderService = new OrderService(customerService, productService)
//EndPoints

//1-Création produit
app.post('/produits', (req:Request<any,any,Product>, res:Response<Message>) => {
    const {title, price, stock} = req.body
    productService.addProduct(title, price, stock)
    res.json({message: "produit ajouté"})
})

//2-Récupération d'un produit par son id
app.get('/produits/:id', (req:Request<Id>, res:Response<Message|Product>) => {
    const product:Product = productService.getProductById(req.params.id)
    if(product != undefined) {
        res.json(product)
    }
    else {
        res.json({message: "aucun produit avec cet id"})
    }
})

//1-Création d'un client
app.post('/clients', (req:Request<any,any,Customer>, res:Response<Message>) => {
    const {firstName, lastName, phone} = req.body
    customerService.addCustomer(firstName, lastName, phone)
    res.json({message: "client ajouté"})
})

//2- Récupération de la liste des clients
app.get('/clients', (req, res:Response<Array<Customer>>) => {
    res.json(customerService.getAllCustomers())
})

//3- Récupération d'un client
app.get('/clients/:id', (req:Request<Id>, res:Response<Message|Customer>) => {
    const customer:Customer = customerService.getCustomerById(req.params.id)
    if(customer != undefined) {
        res.json(customer)
    }
    else {
        res.json({message:"aucun client avec cet id"})
    }
})

//1- Création d'un commande 
app.post('/commandes', (req:Request<any, any, CreateOrder>, res:Response<Message>) => {
    const {customerId, products} = req.body
    if(orderService.addOrder(customerId, products)) {
        res.json({message: "commande ajoutée"})
    }
    else {
        res.json({message: "erreur création de commande"})
    }
})

//2- Récupération de la liste des commandes
app.get('/commandes', (req, res:Response<Array<Order>>) => {
    res.json(orderService.getAllOrders())
})

//3- Récupération d'un commande par son id
app.get('/commandes/:id', (req:Request<Id>, res:Response<Order|Message>) => {
    const order:Order = orderService.getOrderById(req.params.id)
    if(order != undefined) {
        res.json(order)
    }else {
        res.json({message: "aucune commande avec cet id"})
    }
})



app.listen(2000,() => {
    productService.readFromJson()
    customerService.readFromJson()
    orderService.readFromJson()
})