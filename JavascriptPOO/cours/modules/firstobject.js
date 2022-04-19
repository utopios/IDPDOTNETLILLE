export const chaine = "bonjour tout le monde"


//Une fonction qui permet de créer un type personne pour créer des objets personnes

// export function Personne() {
//     //Une fonction en javascript a son propre context
//     //this
//     //Definition des attribut
//     this.nom = "toto"
//     this.prenom = "tata"
//     this.direBonjour = function() {
//         console.log("bonjour " + this.nom)
//     }
// }

//<=> Après 2015
export class Personne {
    //A la construction de chaque objet, on utilise cette méthode
    constructor() {
        //Attributs
        this.nom = "toto"
        this.prenom = "tata"
    }

    //méthodes
    direBonjour() {
        console.log("bonjour")
    }

}