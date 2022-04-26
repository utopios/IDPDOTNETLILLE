import express from "express"
import { App } from "./classes/app.js"

//Un objet pour gérer les données
const dataService = new App()

//Notre objet express
const api = express()

//Utilisation d'un middleware json
api.use(express.json())

//Endpoint pour créer un todo
api.post('/todos', (req, res) => {
    const {title, content} = req.body
    if(title != undefined && content != undefined) {
        dataService.createTodo(title, content)
        res.json({message: "todo ajouté"})
    }
    else
        res.json({message: "Merci de envoyer un titre et un contenu"})
})

//Endpoint pour récuperer la liste des todos
api.get('/todos', (req, res) => {
    res.json(dataService.todos)
})

//Endpoint pour récupérer un seul todo
api.get('/todos/:id', (req, res) => {
    const todo = dataService.findTodoById(req.params.id)
    if(todo != undefined)
        res.json(todo)
    else
        res.json({mesage: "aucun todo avec cet id"})
})

api.listen(80, () => {

})