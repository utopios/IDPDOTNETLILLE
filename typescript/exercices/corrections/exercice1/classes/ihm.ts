import { Formateur } from './formateur';
import { Personne } from './personne';
import { Stagiaire } from './stagiaire';
import { poserUneQuestion } from './../tools/tools';


export class Ihm {
    personnes: Array<Personne> = []
    compteur:number
    constructor() {
        this.compteur = 0
    }

    async menu() {
        let choix: string = ""
        do {
            console.log("1-- ajouter un stagiaire")
            console.log("2-- ajouter un formateur")
            console.log("3-- afficher les personnes");
            console.log();
            console.log("0-- quitter");

            choix = await poserUneQuestion("Merci de choisir : ")
            switch (choix) {
                case "1":
                    const nomStagiaire = await poserUneQuestion("Merci de saisir le nom : ")
                    const prenomStagiaire = await poserUneQuestion("Merci de saisir le prénom : ")
                    const promotion = await poserUneQuestion("Merci de saisir la promotion : ")
                    const stagiaire:Stagiaire = new Stagiaire(++this.compteur, nomStagiaire, prenomStagiaire, promotion)
                    this.personnes.push(<Personne>stagiaire)
                    break;
                case "2":
                    const nomFormateur = await poserUneQuestion("Merci de saisir le nom : ")
                    const prenomFormateur = await poserUneQuestion("Merci de saisir le prénom : ")
                    const modules:Array<string> = []
                    modules.push("module 1")
                    modules.push("module 2")
                    //...c'est mieux avec une boucle do while
                    const formateur = new Formateur(++this.compteur, nomFormateur, prenomFormateur, modules)
                    this.personnes.push(<Personne> formateur)
                    break;
                case "3":
                    this.personnes.forEach(p => {
                        p.afficher()
                    })
                    break;
            }
        } while (choix != '0')
    }
}