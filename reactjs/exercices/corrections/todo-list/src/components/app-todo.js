import { Component } from "react";
import { Route, Routes } from "react-router-dom";
import  DetailTodo  from "./detail-todo";
import { FormTodo } from "./form-todo";
import { HomeTodo } from "./home-todo";
import { ListTodos } from "./list-todos";
import { MenuTodo } from "./menu-todo";
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
           count: newCount,
           searchTodos:[]  
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
        this.setState({ todos: [...tmpTodos], searchTodos:[]    });
    }

    delete = (id) => {
        const tmpTodos = this.state.todos.filter(t => t.id != id)
        this.setState({ todos: [...tmpTodos], searchTodos:[]    });
    }

    find = (id) => {
        return this.state.todos.find(t => t.id == id)
    }
    render() { 
        return ( 
            <div>
                <MenuTodo></MenuTodo>
                <Routes>
                    <Route path="/" element={<HomeTodo />}>                        
                    </Route>
                    <Route path="/formulaire" element={<FormTodo  navigate={this.props.navigate} />}>
                    </Route>
                    <Route path="/detail/:id" element={<DetailTodo find={this.find} />}></Route>
                </Routes>
            </div>
         );
    }
}
 
