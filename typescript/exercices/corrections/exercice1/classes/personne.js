export class Personne {
    id;
    nom;
    prenom;
    constructor(id, nom, prenom) {
        this.id = id;
        this.nom = nom;
        this.prenom = prenom;
    }
    afficher() {
        console.log(`Id : ${this.id}, Nom: ${this.nom}, Prénom: ${this.prenom}`);
    }
}
