export class Personne {
    id:number
    nom:string
    prenom:string
    
    constructor(id:number, nom:string, prenom:string) {
        this.id = id
        this.nom = nom
        this.prenom = prenom
    }

    afficher():void {
        console.log(`Id : ${this.id}, Nom: ${this.nom}, Prénom: ${this.prenom}`)
    }
}