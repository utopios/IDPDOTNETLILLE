import { Contact } from "./contact.js"
import {appendFileSync} from "fs"
export class Data {
    constructor() {
        this.contacts = []
        this.compteur = 0
        this.fichier = "data.csv"
    }

    ajouterContact(nom, prenom, telephone, email) {
        const contact = new Contact(++this.compteur, nom, prenom, telephone,email)
        this.contacts.push(contact)
        appendFileSync(this.fichier, `${contact.id};${contact.nom};${contact.prenom};${contact.telephone};${contact.email};\n`)
    }

    recuperContact(id) {
        return this.contacts.find(c => c.id == id)
    }

    //Modifier => id, nouveau nom, nouveau prénom, nouvel email, nouveau telephone

    modifierContact(id, nom, prenom, telephone, email) {
        const contact = this.recuperContact(id)
        if(contact != undefined) {
            contact.nom = nom
            contact.prenom = prenom
            contact.telephone = telephone
            contact.email = email
            return true
        }
        return false
    }

    //Supprimer => id

    supprimerContact(id) {
        const contact = this.recuperContact(id)
        if(contact != undefined) {
            this.contacts = this.contacts.filter(c => c.id != id)
            return true
        }
        return false
    }
}