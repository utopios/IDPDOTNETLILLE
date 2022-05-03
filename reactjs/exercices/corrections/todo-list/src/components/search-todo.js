import { Component } from "react";
export class SearchTodo extends Component {
    constructor(props) {
        super(props);
        this.state = {
            search : ''
        }
    }
    
    fieldChange = (e) => {
        this.setState({search:e.target.value})
    }
    onSearch = (e) => {
        e.preventDefault()
        this.props.search(this.state.search)
    }
    render() { 
        return ( 
            <form onSubmit={this.onSearch}>
                <input type="text" onChange={this.fieldChange} placeholder="Rechercher todo" />
                <button type="submit">Rechercher</button>
            </form>
         );
    }
}
