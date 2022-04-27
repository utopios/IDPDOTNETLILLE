import express from "express"
import { ProductService } from "./services/productService.js"

const app = express()

app.use(express.json())

//Création de services
const productService = new ProductService()

//EndPoints

//1-Création produit
app.post('/produits', (req, res) => {
    const {title, price, stock} = req.body
    productService.addProduct(title, price, stock)
    res.json({message: "produit ajouté"})
})

//2-Récupération d'un produit par son id
app.get('/produits/:id', (req, res) => {
    const product = productService.getProductById(req.params.id)
    if(product != undefined) {
        res.json(product)
    }
    else {
        res.json({message: "aucun produit avec cet id"})
    }
})

//1-Création d'un client
app.post('/clients', (req, res) => {

})

//2- Récupération de la liste des clients
app.get('/clients', (req, res) => {
    
})

//3- Récupération d'un client
app.get('/clients/:id', (req, res) => {
    
})

//1- Création d'un commande 
app.post('/commandes', (req, res) => {
    
})

//2- Récupération de la liste des commandes
app.get('/commandes', (req, res) => {
    
})

//3- Récupération d'un commande par son id
app.get('/commandes/:id', (req, res) => {
    
})



app.listen(2000,() => {
    productService.readFromJson()
})