import { Personne } from "./personne";
export class Formateur extends Personne {
    modules = [];
    constructor(id, nom, prenom, modules) {
        super(id, nom, prenom);
        this.modules = modules;
    }
    afficher() {
        super.afficher();
        this.modules.forEach(m => {
            console.log(m);
        });
    }
}
