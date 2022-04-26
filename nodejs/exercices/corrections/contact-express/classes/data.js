import { Contact } from "./contact.js"
import {appendFileSync} from "fs"
import LineByLine from "n-readlines"
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

    lire() {
        this.contacts = []
        const reader = new LineByLine(this.fichier)
        let line
        while(line = reader.next()) {
            const donnees = line.toString().split(';')
            const contact = new Contact(donnees[0], donnees[1], donnees[2], donnees[3], donnees[4])
            this.contacts.push(contact)
        }
        this.compteur = this.contacts[this.contacts.length-1].id
        return this.contacts
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