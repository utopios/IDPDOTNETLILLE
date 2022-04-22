import { poserUneQuestion } from "../tools.js"

export class Ihm {
    constructor() {
      this.personnes = []  
    }

    async menu() {
        let choix
        do {
            console.log("1-- ajouter une personne")
            console.log("2-- afficher les personnes")
            choix = await poserUneQuestion("Merci de choisir : ")
            switch(choix) {
                case "1":
                    const nom = await poserUneQuestion("Merci de saisir le nom : ")
                    const prenom = await poserUneQuestion("Merci de saisir le prénom : ")
                    this.personnes.push({nom: nom, prenom: prenom})
                    break;
                case "2":
                    this.personnes.forEach(p => {
                        console.log(`Nom : ${p.nom}, Prénom: ${p.prenom}`)
                    })
                    break;
            }
        }while(choix != '0')
    }
}