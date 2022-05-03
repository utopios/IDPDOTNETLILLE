import {Component} from "react"
export class Todo extends Component{
    constructor(props) {
        super(props)
        
    }
    delete = (e) => {
        e.preventDefault()
        const {id} = this.props.todo
        this.props.delete(id)
    }

    update = (e) => {
        const {id} = this.props.todo
        this.props.update(id)
    }
    render() {
        const {title, content, status} = this.props.todo
        return(
            <div className="row">
                <div className="col">
                    {title}
                </div>
                <div className="col">
                    {content}
                </div>
                <div className="col">
                    <a onClick={this.delete}>supprimer</a>
                    <input type="checkbox" onChange={this.update} checked={status} />
                </div>
            </div>
        )
    }
}