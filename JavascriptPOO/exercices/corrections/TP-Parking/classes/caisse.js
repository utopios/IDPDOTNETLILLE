import { Vehicule } from "./vehicule.js"

export class Caisse {
    constructor() {
        this.vehicules = []
    }

    menu() {
        //Afficher le menu et en fonction de la réponse on execute deux scénarios
        let choix = undefined
        do {
            choix = prompt("1- Obtenir un ticket \n2- Payer le parking\n0-Quitter")
            switch(choix) {
                case '1':
                    this.getTicket()
                    break
                case '2':
                    this.payTicket()
                    break
            }
        }while(choix != '0')
         
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
            const time = Math.round(vehicule.getTime())
            console.log(time)
            let prix = 6
            if(time < 15) {
                prix = 0.8
            }
            else if(time < 30) {
                prix = 1.3     
            }
            else if(time < 45) {
                prix = 1.7
            }
            alert(`le prix est de ${prix} euros`)
        }
        else {
            alert("pas de vehicule avec cette immatriculation dans le parking")
        }
    }
}