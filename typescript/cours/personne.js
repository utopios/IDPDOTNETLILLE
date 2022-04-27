export class Personne {
    //Attributs
    nom;
    prenom;
    constructor(n, p) {
        this.nom = n;
        this.prenom = p;
    }
    afficher() {
        console.log(this.nom + " " + this.prenom);
    }
    nomComplet() {
        return this.nom + " " + this.prenom;
    }
}
