import { Todo } from "./todo.js"

export class Ihm {
    constructor(formulaireRecherche, formulaireAjout, resultat) {
        this.todos = []
        this.compteur = 0
        this.formulaireAjout = formulaireAjout
        this.formulaireRecherche = formulaireRecherche
        this.resultat = resultat
    }

    demarrer() {
        this.ajouterEvent()
    }

    ajouterEvent() {
        this.formulaireAjout.addEventListener('submit', (e) => {
            e.preventDefault()
            this.ajouterTodo().then(res => {
                this.resultat.innerHTML += res.renduHTML
            })
        })
        this.resultat.addEventListener('click', (e) => {
            const action = e.target.getAttribute("data-action")
            const id = e.target.getAttribute("data-id")
            switch(action) {
                case "update":
                    break;
                case "delete":
                    break;
            }
        })
    }

    afficherToDos() {
        
    }

    ajouterTodo() {
        return new Promise((resolve, reject) => {
            const titre = this.formulaireAjout.querySelector("input[name='titre']").value
            const contenu = this.formulaireAjout.querySelector("textarea[name='contenu']").value
            const todo = new Todo(++this.compteur, titre, contenu)
            this.todos.push(todo)
            resolve({renduHTML: `<tr><td>${todo.id}</td><td>${todo.titre}</td><td>${todo.contenu}</td><td><input data-action='update' data-id='${todo.id}' type='checkbox' ${todo.status ? 'checked' : ''} /><span data-action='delete' data-id='${todo.id}' class="material-symbols-outlined">delete</span></td></tr>`})
        })
    }

    rechercherTodo() {
        return new Promise((resolve, reject) => {

        })
    }

    changerStatusTodo() {
        return new Promise((resolve, reject) => {

        })
    }

    supprimerTodo() {
        return new Promise((resolve, reject) => {
            
        })
    }


}