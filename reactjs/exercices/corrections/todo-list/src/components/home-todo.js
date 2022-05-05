import { ListTodos } from "./list-todos";
import { SearchTodo } from "./search-todo";
import {useState} from "react"
import {actionSearchTodos} from "./../services/todos.service"
export const HomeTodo = (props) => {
    const [searchTodos, setSearchTodos] = useState([])

    const searchTodo = (search) => {
        actionSearchTodos(search).then(res => {
            setSearchTodos(res)
        })
    }
    return(
        <div>
            <SearchTodo search={searchTodo}></SearchTodo>
            <ListTodos  todos={searchTodos}></ListTodos>
        </div>
    )
}