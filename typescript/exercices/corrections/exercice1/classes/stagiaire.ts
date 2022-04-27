import { Personne } from "./personne";

export class Stagiaire extends Personne {
    promotion:string
    constructor(id:number, nom:string, prenom:string, promotion:string) {
        super(id, nom, prenom)
        this.promotion = promotion
    }

    afficher(): void {
        super.afficher()
        console.log("Promotion: "+this.promotion)
    }
}