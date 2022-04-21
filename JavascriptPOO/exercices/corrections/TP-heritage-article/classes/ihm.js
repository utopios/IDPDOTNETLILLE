import { Produit } from "./produit.js"
import { Service } from "./service.js"

export class Ihm {

    constructor(formulaire, domProduits, domServices) {
        this.articles = []
        this.formulaire = formulaire
        this.domProduits = domProduits
        this.domServices = domServices
    }

    demarrer() {
        this.addEvent()
    }

    addEvent() {
        //Détection de l'event change sur la radio
        const radios = this.formulaire.querySelector("#parentRadio")
        radios.addEventListener('change', (e) => {
            console.log(e.target.value)
            this.switchProduitService(e.target.value)
        })

        this.formulaire.addEventListener('submit', (e) => {
            e.preventDefault()
            this.ajouterArticle()
        })
    }

    ajouterArticle() {
        const type = this.formulaire.querySelector("input[name='type']:checked").value
        //Si produit => ajouterProduit
        if(type == 'produit') {
            this.ajouterProduit()
        }
        //Si Service => ajouterService
        else if(type == 'service') {
            this.ajouterService()
        }
    }

    ajouterProduit() {
        //Ajouter produit 
        //Récupération des champs
        const titre = document.querySelector("input[name='titre']").value
        const prix= document.querySelector("input[name='prix']").value
        const description= document.querySelector("textarea[name='description']").value
        const stock= document.querySelector("input[name='stock']").value
        //Faire des vérification sur les champs...
        const produit = new Produit(titre, prix, description, stock)
        this.articles.push(produit)
        this.domProduits.innerHTML += `<tr><td>${titre}</td><td>${prix}</td><td>${description}</td><td>${stock}</td></tr>`
    }

    ajouterService() {
        //Ajouter service
        const titre = document.querySelector("input[name='titre']").value
        const prix= document.querySelector("input[name='prix']").value
        const description= document.querySelector("textarea[name='description']").value
        const domaine= document.querySelector("input[name='domaine']").value
        //Faire des vérification sur les champs...
        const service = new Service(titre, prix, description, domaine)
        this.articles.push(service)
        this.domServices.innerHTML += `<tr><td>${titre}</td><td>${prix}</td><td>${description}</td><td>${domaine}</td></tr>`
    }

    switchProduitService(type) {
        const inputStock = this.formulaire.querySelector("input[name='stock']")
        const inputDomaine = this.formulaire.querySelector("input[name='domaine']")
        if(type == "produit") {
            
            inputDomaine.style.display = 'none'
            inputStock.style.display = 'block'
        }
        else if(type =="service") {
            inputDomaine.style.display = 'block'
            inputStock.style.display = 'none'
        }
    }
}