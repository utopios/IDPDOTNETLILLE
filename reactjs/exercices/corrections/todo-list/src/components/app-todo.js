import { Component } from "react";
import { FormTodo } from "./form-todo";
import { ListTodos } from "./list-todos";

export class AppTodo extends Component {
    constructor(props) {
        super(props);
        this.state = {
            todos : [],
            count : 0
        }
    }
    addTodo = (todo) => {
        const createdTodo = {id:this.state.count + 1, ...todo}
        this.setState({ 
           todos : [...this.state.todos, createdTodo],
           count: this.state.count + 1  
        });
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
                <ListTodos delete={this.delete} update={this.update} todos={this.state.todos}></ListTodos>
            </div>
         );
    }
}
 
