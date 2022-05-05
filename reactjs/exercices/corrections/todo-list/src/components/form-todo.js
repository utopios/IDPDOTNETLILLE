import { Component } from "react";
import { addTodos } from "../services/todos.service";
export class FormTodo extends Component {
    constructor(props) {
        super(props);
        this.state = {
            todo : {
                title: undefined,
                content: undefined
            }
        }
    }
    fieldsOnChange = (e) => {
        const tmpTodo = this.state.todo
        tmpTodo[e.target.getAttribute("name")] = e.target.value
        this.setState({ todo: {...tmpTodo}  });
    }

    confirm = (e) => {
        e.preventDefault()
        addTodos({...this.state.todo, status:false})
        this.props.navigate("/")
    }
    render() { 
        return ( 
            <form onSubmit={this.confirm}>
                <div>
                    <input type="text" name="title" onChange={this.fieldsOnChange}  placeholder="titre de la todo" />
                </div>
                <div>
                    <textarea name="content" onChange={this.fieldsOnChange} placeholder="contenu de la todo" ></textarea>
                </div>
                <div>
                    <button type="submit">Valider</button>
                </div>
            </form>
         );
    }
}
 
