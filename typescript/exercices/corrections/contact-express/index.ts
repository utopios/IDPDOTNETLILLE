import express, { Request, Response } from "express"
import { Contact } from "./classes/contact"
import { Data } from "./classes/data.js"
import { ContactInterface } from "./interface/contact.interface.js"
import { Id } from "./interface/id.interface"
import { Message } from "./interface/message.interface"

const data = new Data()

const app = express()

app.use(express.json())

app.get('/contacts', (req:Request, res:Response<Array<Contact>>) => {
    res.json(data.contacts)
})

app.get('/contacts/:id', (req:Request<Id>, res:Response<Message|Contact>) => {
    const contact:Contact = data.recuperContact(req.params.id)
    if(contact != undefined) {
        res.json(data.recuperContact(req.params.id))
    }else {
        res.json({message: "aucun contact avec cet id"})
    }
})

app.put("/contacts/:id", (req:Request<Id,any,ContactInterface>, res:Response<Message>)=> {
    const {nom, prenom, telephone, email} = req.body
    if(data.modifierContact(req.params.id, nom, prenom, telephone, email)) {
        res.json({message : "contact modifié"})
    }
    else {
        res.json({message: "erreur modification"})
    }
})

app.post('/contacts', (req:Request<any,any,ContactInterface>, res:Response<Message>) => {
    const {nom, prenom, telephone, email} = req.body
    data.ajouterContact(nom, prenom, telephone, email)
    res.json({message : "contact ajouté"})
})

app.delete("/contacts/:id", (req:Request<Id>, res:Response<Message>) => {
    if(data.supprimerContact(req.params.id)) {
        res.json({message : "contact supprimé"})
    }
    else {
        res.json({message: "erreur suppression contact"})
    }
})

app.listen(5000, () => {
    data.lire()
})
