import { Contact } from "./contact.js"

export class Data {
    constructor() {
        this.contacts = []
        this.compteur = 0
    }

    ajouterContact(nom, prenom, telephone, email) {
        const contact = new Contact(++this.compteur, nom, prenom, email, telephone)
        this.contacts.push(contact)
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