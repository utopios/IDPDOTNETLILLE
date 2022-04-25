import express from "express"
import { Data } from "./classes/data.js"

const data = new Data()

const app = express()

app.use(express.json())

app.get('/contacts', (req, res) => {
    res.json(data.contacts)
})

app.post('/contacts', (req, res) => {
    const {nom, prenom, telephone, email} = req.body
    data.ajouterContact(nom, prenom, telephone, email)
    res.json({message : "contact ajouté"})
})

app.listen(5000, () => {

})
