export class Contact {

    constructor() {
        this.nom = ""
        this.prenom = ""
        this.email = ""
        this.telephone = ""
        this.dateNaissance = ""
    }

    afficher() {
        console.log(`Nom: ${this.nom}, Prénom: ${this.prenom}, Téléphone:${this.telephone}`)
    }
}