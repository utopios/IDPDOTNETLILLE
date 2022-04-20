import {Personne} from "./personne.js"
export class Formateur extends Personne {
    constructor(n, p, t, m) {
        super(n,p,t)
        this.langage = m
    }

    afficher() {
        super.afficher()
        console.log(this.langage)
        
    }

}