import { useParams } from "react-router-dom"

export const DetailTodo = (props) => {
    const parms = useParams()
    const id = parms.id
    let todo = undefined
    if(id != undefined) {
        todo = props.find(id)
    }

    return(
        <div>
            {todo == undefined 
            ? 
            (<div>Pas de todo avec cet id</div>)
            :
            (<div>
                {todo.title}<br/>
                {todo.content}
            </div>)
        }
        </div>
    )
}