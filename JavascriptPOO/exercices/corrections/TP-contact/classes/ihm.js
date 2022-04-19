import { Contact } from "./contact.js"

export class Ihm {
    constructor(formulaire, tableauHtmlResultat) {
        this.formulaire = formulaire
        this.tableauHtmlResultat = tableauHtmlResultat
        this.contacts = []
    }

    demarrer() {
        this.formulaire.addEventListener('submit', (e) => {
            e.preventDefault()
            this.ajouter()
        })
    }

    ajouter() {
        //Récupérer les champs et créer un contact
        // const radios = this.formulaire.querySelectorAll("input[name='titre']")
        // let titre = ""
        // radios.forEach(c => {
        //     if(c.checked == true) {
        //         titre = c.value
        //     }
        // })
        const titre = this.formulaire.querySelector("input[name='titre']:checked").value
        const nom = this.formulaire.querySelector("input[name='nom']").value
        const prenom = this.formulaire.querySelector("input[name='prenom']").value
        const telephone = this.formulaire.querySelector("input[name='telephone']").value
        const email = this.formulaire.querySelector("input[name='email']").value
        const dateNaissance= this.formulaire.querySelector("input[name='dateNaissance']").value
        const contact = new Contact(nom, prenom, telephone, email, dateNaissance, titre)
        this.contacts.push(contact)
        this.afficher(contact)
    }

    afficher(c) {
        this.tableauHtmlResultat.innerHTML += `<tr>
        <td>${c.titre}</td> 
        <td>${c.nom}</td>
        <td>${c.prenom}</td> 
        <td>${c.telephone}</td> 
        <td>${c.email}</td>
        <td>${c.dateNaissance}</td>
        </tr>`
        
        // this.contacts.forEach(c => {
        //     this.innerHTML += `<div>
        //     ${c.titre} 
        //     ${c.nom} 
        //     ${c.prenom} 
        //     ${c.telephone} 
        //     ${c.email}
        //     ${c.dateNaissance}
        //     </div>`
        // })
    }
}