//Exemple d'import à partir d'un autre module
// import {config1, direBonjour as Bonjour} from "./modules/configuration.js"

import { chaine, Personne } from "./modules/firstobject.js";

// import elementDefault from "./modules/configuration.js"

// //alert(config1)

// //Bonjour()

// alert(elementDefault)

// console.log(chaine.length)

// console.log(chaine.indexOf('o'))

// const tableauPersonnes = []

// //Selectionner le formulaire
// const formPersonne = document.querySelector("#formPersonne")
// const result = document.querySelector("#result")
// formPersonne.addEventListener('submit', (e) => {
//     //L'arret de l'envoie du formulaire.
//     e.preventDefault()
//     //Récupérer les valeurs des champs
//     const nom = formPersonne.querySelector("input[name='nom']").value
//     const prenom = formPersonne.querySelector("input[name='prenom']").value
//     const p = new Personne(nom, prenom)
//     tableauPersonnes.push(p)
//     console.log(tableauPersonnes)
//     result.innerHTML += `<div class='row'><div class='col'>${p.nom}</div>
//     <div class='col'>${p.prenom}</div></div>`
// })


// const p1 = new Personne(valSaisi, "tata")
// // p1.nom = "titi"
// console.log(p1.nom)
// p1.direBonjour()


//Exemple de prompt



//Réaliser un timer
const timer = document.querySelector("#timer")
const btnIn = document.querySelector("#entrer")
const btnOut = document.querySelector("#sortir")
let intTime, outTime
let temps = 0

// setInterval(() => {
//     new Date()
// },1000)

// setTimeout(() => {
//     const result = prompt("Bonjour tout le monde \n Question : ");
//     alert(result)
// },2000)
btnIn.addEventListener('click', (e) => {
    intTime = new Date()
})

btnOut.addEventListener('click', (e) => {
    outTime = new Date()
    console.log(intTime)
    console.log(outTime)
    alert((outTime-intTime)/1000)
})


