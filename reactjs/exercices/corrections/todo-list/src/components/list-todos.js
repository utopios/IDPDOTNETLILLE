import { Component } from "react";
import { Todo } from "./todo";
export class ListTodos extends Component {
    constructor(props) {
        super(props);
    }
    render() { 
        const {todos, update} = this.props
        return ( 
            <div>
                {todos.map((t,i) => (<Todo key={i} todo={t} update={update} delete={this.props.delete}></Todo>))}
            </div>
         );
    }
}
 
