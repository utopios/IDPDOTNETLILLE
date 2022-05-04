import { ListTodos } from "./list-todos";
import { SearchTodo } from "./search-todo";
export const HomeTodo = (props) => {

    return(
        <div>
            <SearchTodo search={props.search}></SearchTodo>
            <ListTodos delete={props.delete} update={props.update} todos={ props.todos}></ListTodos>
        </div>
    )
}