import { Jeu } from "./jeu.js"
import { poserUneQuestion } from "./tools.js"

export class Ihm {
    constructor() {
        this.fin = false
        this.first = true
        this.jeu = new Jeu()
    }

    async getPositions() {
        const joueur = this.first ? 'X' : 'O'
        console.log("Joueur : "+ joueur)
        const x =  await poserUneQuestion("Merci de saisir x : ")
        const y = await poserUneQuestion("Merci de saisir y : ")
        return {joueur :joueur, x:x, y:y}
    }

    async demarrer() {
        while(!this.fin) {
            const res =await this.getPositions()
            if(this.jeu.jouer(res.joueur, res.x, res.y)) {
                this.first = !this.first
                this.jeu.afficher()
                if(this.jeu.testwin(res.joueur)) {
                    console.log("bravo "+ joueur)
                }
                this.fin = this.jeu.testFin()
            }
        }
    }
}