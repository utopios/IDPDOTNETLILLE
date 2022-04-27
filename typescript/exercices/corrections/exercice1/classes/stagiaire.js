import { Personne } from "./personne";
export class Stagiaire extends Personne {
    promotion;
    constructor(id, nom, prenom, promotion) {
        super(id, nom, prenom);
        this.promotion = promotion;
    }
    afficher() {
        super.afficher();
        console.log("Promotion: " + this.promotion);
    }
}
