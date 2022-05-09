import { Component } from "react";
import { getTodos, updateTodo } from "../services/todos.service";
import { Todo } from "./todo";

export class ListTodos extends Component {
    constructor(props) {
        super(props);
        this.state = {
            todos : []
        }
    }

    componentDidMount() {
        this.fetchData()
    }

    fetchData = () => {
        getTodos().then((res) => {
            this.setState({ todos:[...res.data]  });
        })
    }

    update = (id) => {
        if(updateTodo(id)) {
            this.fetchData()
        }
    }

    delete = (id) => {

    }
    render() { 
        const todos = this.props.todos.length > 0 ? this.props.todos : this.state.todos
        return ( 
            <div>
                {todos.map((t,i) => (<Todo key={i} todo={t} update={this.update} delete={this.delete}></Todo>))}
            </div>
         );
    }
}
 
