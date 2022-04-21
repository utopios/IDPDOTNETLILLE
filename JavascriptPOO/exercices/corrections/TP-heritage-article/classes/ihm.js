
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
    }

    ajouterService() {
        //Ajouter service
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