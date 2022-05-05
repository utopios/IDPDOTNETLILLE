const todos = [

]

let id = 0

export const getTodos = () => new Promise((r, rej) => {
    r(todos)
})

export const findTodoById =  (id) => new Promise((r, rej) => {
    r(todos.find(t => t.id == id))
})

export const actionSearchTodos = (search) =>  new Promise((r, rej) => {
    r(todos.filter(t => t.title.includes(search)))
})

export const addTodos = (todo) => {
    todos.push({id: ++id,...todo})
}

export const updateTodo = (id) => {
    const todo = todos.find(t => t.id == id)
    if(todo != undefined) {
        todo.status = !todo.status
        return true
    }
    return false
}