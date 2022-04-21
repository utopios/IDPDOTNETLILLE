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
        const loader = this.formulaire.querySelector("#loader")
        radios.addEventListener('change', (e) => {
            console.log(e.target.value)
            this.switchProduitService(e.target.value)
        })

        this.formulaire.addEventListener('submit', (e) => {
            e.preventDefault()
            //Démarrer le loader
            loader.style.display = 'block'
            this.ajouterArticle().then(res => {
                if (res.type == "produit") {
                    this.domProduits.innerHTML += res.renduHtml
                }
                else if (res.type == "service") {
                    this.domServices.innerHTML += res.renduHtml
                }
                loader.style.display = 'none'
            }).catch(err => {
                alert(err.message)
                loader.style.display = 'none'
            })
        })
    }

    ajouterArticle() {
        return new Promise((resolve, reject) => {
            const type = this.formulaire.querySelector("input[name='type']:checked").value
            setTimeout(() => {
                //Si produit => ajouterProduit
                if (type == 'produit') {
                    resolve(this.ajouterProduit())
                }
                //Si Service => ajouterService
                else if (type == 'service') {
                    resolve(this.ajouterService())
                }
                else {
                    reject(new { message: 'type incorrect' })
                }
            }, 3000)
        })
    }

    ajouterProduit() {
        //Ajouter produit 
        //Récupération des champs
        const { titre, description, prix, renduHtml } = this.constructionArticle()
        const stock = document.querySelector("input[name='stock']").value
        //Faire des vérification sur les champs...
        const produit = new Produit(titre, prix, description, stock)
        this.articles.push(produit)
        //this.domProduits.innerHTML += `<tr>${renduHtml}<td>${stock}</td></tr>`
        return  { type: 'produit', renduHtml: `<tr>${renduHtml}<td>${stock}</td></tr>` }
    }

    ajouterService() {
        //Ajouter service
        // const titre = document.querySelector("input[name='titre']").value
        // const prix= document.querySelector("input[name='prix']").value
        // const description= document.querySelector("textarea[name='description']").value
        // const domaine= document.querySelector("input[name='domaine']").value
        // //Faire des vérification sur les champs...
        // const service = new Service(titre, prix, description, domaine)
        // this.articles.push(service)
        // this.domServices.innerHTML += `<tr><td>${titre}</td><td>${prix}</td><td>${description}</td><td>${domaine}</td></tr>`

        //<=> Avec un desctructeur 
        const { titre, description, prix, renduHtml } = this.constructionArticle()
        const domaine = document.querySelector("input[name='domaine']").value
        //Faire des vérification sur les champs...
        const service = new Service(titre, prix, description, domaine)
        this.articles.push(service)
        //this.domServices.innerHTML += `<tr>${renduHtml}<td>${domaine}</td></tr>`
        return  { type: 'service', renduHtml: `<tr>${renduHtml}<td>${domaine}</td></tr>` }
    }

    constructionArticle() {
        const titre = document.querySelector("input[name='titre']").value
        const prix = document.querySelector("input[name='prix']").value
        const description = document.querySelector("textarea[name='description']").value
        return {
            titre: titre,
            prix: prix,
            description: description,
            renduHtml: `<tr><td>${titre}</td><td>${prix}</td><td>${description}</td>`
        }
    }

    switchProduitService(type) {
        const inputStock = this.formulaire.querySelector("input[name='stock']")
        const inputDomaine = this.formulaire.querySelector("input[name='domaine']")
        if (type == "produit") {

            inputDomaine.style.display = 'none'
            inputStock.style.display = 'block'
        }
        else if (type == "service") {
            inputDomaine.style.display = 'block'
            inputStock.style.display = 'none'
        }
    }
}