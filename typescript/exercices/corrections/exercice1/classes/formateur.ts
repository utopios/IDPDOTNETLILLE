import { Personne } from "./personne";

export class Formateur extends Personne {
    modules:Array<string> = []
    constructor(id:number, nom:string, prenom:string, modules:Array<string>) {
        super(id, nom, prenom)
        this.modules = modules
    }

    afficher(): void {
        super.afficher()
        this.modules.forEach(m=> {
            console.log(m)
        })
    }
}