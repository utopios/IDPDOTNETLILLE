export class Personne {
    constructor(n,p, t) {
        this.nom = n
        this.prenom = p
        this.telephone = t
    }

    afficher() {
        console.log(`une personne ${this.nom} ${this.prenom} ${this.telephone}`)
    }
}