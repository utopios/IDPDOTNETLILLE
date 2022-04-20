import { Vehicule } from "./vehicule"

export class Caisse {
    constructor() {
        this.vehicules = []
    }

    menu() {
        //Afficher le menu et en fonction de la réponse on execute deux scénarios

    }

    getTicket() {
        //Le scénario => un nouveau vehicule dans le parking
        const immatriculation = prompt("Merci de saisir l'immatriculation du vehicule")
        const vehicule = new Vehicule(immatriculation)
        this.vehicules.push(vehicule)
    }

    payTicket() {
        //Le scénario => sorti d'un vehicule du parking
        const immatriculation = prompt("Merci de saisir l'immatriculation du vehicule")
        let vehicule = undefined
        for(let i=0; i < this.vehicules.length; i++) {
            if(this.vehicules[i].immatriculation == immatriculation) {
                vehicule = this.vehicules[i]
                break
            }
        }

        if(vehicule != undefined) {
            //Calculer le prix du parking
        }
        else {
            alert("pas de vehicule avec cette immatriculation dans le parking")
        }
    }
}