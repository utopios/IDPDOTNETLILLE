import { Avion } from "./avion";
import { Oiseau } from "./oiseau";
//Typage des variables
const age = 30;
const nom = "abadi";
//const p = new Personne("abadi", "ihab")
const test = true;
const stringNumber = "20";
const nombre = 30;
//Cast entre deux types se fait à l'aide  de <>
//ICI cast impossible
// const total = <number>stringNumber + nombre
// const total:number = parseInt(stringNumber) + nombre
// const personnes:Array<Personne> = []
// personnes.push(p)
//personnes.push("ttoo")
// const p1 = {nom: "toto", 
//             prenom:"tata", 
//             afficher:()=> {}, 
//             nomComplet : ():String => {return ""}
//         }
// const p:Personne = <Personne>p1
// console.log(p.nom)
const avion = new Avion();
const oiseau = new Oiseau();
const v = [];
v.push(avion);
v.push(oiseau);
