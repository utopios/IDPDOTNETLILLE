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

        this.formulaireRecherche.addEventListener('submit', (e) => {
            e.preventDefault()
            this.rechercherTodos().then(res => {
                this.afficherToDos(res)
            })
        })

        this.resultat.addEventListener('click', (e) => {
            const action = e.target.getAttribute("data-action")
            const id = e.target.getAttribute("data-id")
            switch(action) {
                case "update":
                    console.log("update")
                    this.changerStatusTodo(id).then(res => {
                        if(res) {
                            alert("satut changé")
                        }
                    })
                    break;
                case "delete":
                    console.log("delete")
                    this.supprimerTodo(id).then(res => {
                        if(res) {
                            alert("task supprimée")
                        }
                    })
                    break;
            }
        })
    }

     afficherToDos(todos) {
        this.resultat.innerHTML = ""
        todos.forEach(todo => {
            this.resultat.innerHTML += `<tr data-element=${todo.id}><td>${todo.id}</td><td>${todo.titre}</td><td>${todo.contenu}</td><td><input data-action='update' data-id='${todo.id}' type='checkbox' ${todo.status ? 'checked' : ''} /><span data-action='delete' data-id='${todo.id}' class="material-symbols-outlined">delete</span></td></tr>`
        })
     }

    ajouterTodo() {
        return new Promise((resolve, reject) => {
            const titre = this.formulaireAjout.querySelector("input[name='titre']").value
            const contenu = this.formulaireAjout.querySelector("textarea[name='contenu']").value
            const todo = new Todo(++this.compteur, titre, contenu)
            this.todos.push(todo)
            resolve({renduHTML: `<tr data-element=${todo.id}><td>${todo.id}</td><td>${todo.titre}</td><td>${todo.contenu}</td><td><input data-action='update' data-id='${todo.id}' type='checkbox' ${todo.status ? 'checked' : ''} /><span data-action='delete' data-id='${todo.id}' class="material-symbols-outlined">delete</span></td></tr>`})
        })
    }

    rechercherTodos() {
        return new Promise((resolve, reject) => {
            const search = this.formulaireRecherche.querySelector("input[name='search']").value
            if(search == undefined || search == '' ) {
                resolve(this.todos)
            }
            else {
                resolve(this.todos.filter(t => t.titre.includes(search)))
            }
        })
    }

    changerStatusTodo(id) {
        return new Promise((resolve, reject) => {
            const todo = this.todos.find(t => t.id == id)
            todo.status = !todo.status
            console.log(this.todos)
            resolve(true)
        })
    }

    supprimerTodo(id) {
        return new Promise((resolve, reject) => {
            this.todos = this.todos.filter(t => t.id != id)
            this.resultat.querySelector("tr[data-element='"+id+"']").remove()
            resolve(true)
        })
    }


}