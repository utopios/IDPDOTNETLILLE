
import {appendFileSync, writeFileSync} from "fs"
import LineByLine from "n-readlines"
import { Contact } from "./contact.js"
export class Data {
    contacts:Array<Contact> = []
    compteur:number = 0
    fichier:string = "data.csv"
    constructor() {

    }

    ajouterContact(nom:string, prenom:string, telephone:string, email:string):void {
        const contact = new Contact(++this.compteur, nom, prenom, telephone,email)
        this.contacts.push(contact)
        appendFileSync(this.fichier, `${contact.id};${contact.nom};${contact.prenom};${contact.telephone};${contact.email};\n`)
    }

    lire():Array<Contact> {
        this.contacts = []
        const reader:LineByLine = new LineByLine(this.fichier)
        let line:Buffer|false
        while(line = reader.next()) {
            const donnees = line.toString().split(';')
            const contact = new Contact(parseInt(donnees[0]), donnees[1], donnees[2], donnees[3], donnees[4])
            this.contacts.push(contact)
        }
        this.compteur = this.contacts[this.contacts.length-1].id
        return this.contacts
    }

    ecrire():void {
        let content:string =""
        this.contacts.forEach(contact => {
            content += `${contact.id};${contact.nom};${contact.prenom};${contact.telephone};${contact.email};\n`
        })
        writeFileSync(this.fichier, content)
    }

    recuperContact(id:number):Contact {
        return this.contacts.find(c => c.id == id)
    }

    //Modifier => id, nouveau nom, nouveau prénom, nouvel email, nouveau telephone

    modifierContact(id:number, nom:string, prenom:string, telephone:string, email:string):boolean {
        const contact:Contact = this.recuperContact(id)
        if(contact != undefined) {
            contact.nom = nom
            contact.prenom = prenom
            contact.telephone = telephone
            contact.email = email
            this.ecrire()
            return true
        }
        return false
    }

    //Supprimer => id

    supprimerContact(id:number):boolean {
        const contact:Contact = this.recuperContact(id)
        if(contact != undefined) {
            this.contacts = this.contacts.filter(c => c.id != id)
            this.ecrire()
            return true
        } 
        return false
    }
}