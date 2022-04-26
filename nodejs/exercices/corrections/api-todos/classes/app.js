import { Todo } from "./todo.js"

export class App {
    constructor() {
        this.todos = []
        this.count = 0
    }

    //Méthode de création
    createTodo(title, content) {
        const todo = new Todo(++this.count, title, content)
        this.todos.push(todo)
    }

    //Méthode pour récupérer un todo par id
    findTodoById(id) {
        return this.todos.find(t => t.id == id)
    }

    //Methode pour rechercher todos par titre
    searchTodosByTitle(search) {
        return this.todos.filter(t => t.title.includes(search))
    }


    //Methode pour mettre à jour le statut d'un todo
    updateTodoStatus(id) {
        const todo = this.findTodoById(id)
        if(todo != undefined) {
            todo.status = !todo.status
            return true
        }
        return false
    }

    //Methode pour supprimer un todo
    deleteTodo(id) {
        const todo = this.findTodoById(id)
        if(todo != undefined) {
            this.todos = this.todos.filter(t => t.id != id)
            return true
        }
        return false
    }
}