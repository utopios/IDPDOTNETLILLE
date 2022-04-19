//Exemple d'import à partir d'un autre module
// import {config1, direBonjour as Bonjour} from "./modules/configuration.js"

import { chaine, Personne } from "./modules/firstobject.js";

// import elementDefault from "./modules/configuration.js"

// //alert(config1)

// //Bonjour()

// alert(elementDefault)

// console.log(chaine.length)

// console.log(chaine.indexOf('o'))

const p1 = new Personne()
p1.nom = "titi"
console.log(p1.nom)
p1.direBonjour()
