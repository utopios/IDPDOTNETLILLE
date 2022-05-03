import { Component } from "react";
import { FormTodo } from "./form-todo";
import { ListTodos } from "./list-todos";
import { SearchTodo } from "./search-todo";

export class AppTodo extends Component {
    constructor(props) {
        super(props);
        this.state = {
            todos : [],
            count : 0,
            searchTodos:[]
        }
    }
    addTodo = (todo) => {
        const newCount = this.state.count + 1
        const createdTodo = {id:newCount, ...todo}
        this.setState({ 
           todos : [...this.state.todos, createdTodo],
           count: newCount  
        });
    }

    search = (val) => {
        const tmpSearchTodos = this.state.todos.filter(t => t.title.includes(val))
        if(tmpSearchTodos.length > 0) {
            this.setState({
                searchTodos: [...tmpSearchTodos]
            })
        } 
    }
    update = (id) => {
        const tmpTodos = [...this.state.todos]
        tmpTodos.forEach(t => {
            if(t.id == id) {
                t.status = !t.status
            }
        })
        this.setState({ todos: [...tmpTodos]  });
    }

    delete = (id) => {
        const tmpTodos = this.state.todos.filter(t => t.id != id)
        this.setState({ todos: [...tmpTodos]  });
    }
    render() { 
        return ( 
            <div>
                <FormTodo addTodo={this.addTodo}></FormTodo>
                <SearchTodo search={this.search}></SearchTodo>
                <ListTodos delete={this.delete} update={this.update} todos={ (this.state.searchTodos.length > 0) ? this.state.searchTodos : this.state.todos}></ListTodos>
            </div>
         );
    }
}
 
