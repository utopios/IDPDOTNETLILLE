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
}