import axios from "axios"
const todos = [

]

let id = 0

// export const getTodos = () => new Promise((r, rej) => {
//     r(todos)
// })

export const getTodos = () => {
    return axios.get("http://localhost/todos")
}

// export const findTodoById =  (id) => new Promise((r, rej) => {
//     r(todos.find(t => t.id == id))
// })

export const findTodoById =  (id) => {
    return axios.get("http://localhost/todos/"+id)
}

export const actionSearchTodos = (search) =>  new Promise((r, rej) => {
    r(todos.filter(t => t.title.includes(search)))
})

export const addTodos = (todo) => {
    return axios.post("http://localhost/todos", {...todo})
    // todos.push({id: ++id,...todo})
}

export const updateTodo = (id) => {
    const todo = todos.find(t => t.id == id)
    if(todo != undefined) {
        todo.status = !todo.status
        return true
    }
    return false
}