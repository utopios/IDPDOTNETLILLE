import { Component } from "react";
import { withNavigate } from "../tools/with-navigate";

import { withParams } from "../tools/with-params";

// export const DetailTodo = (props) => {
//     const parms = useParams()
//     const id = parms.id
//     let todo = undefined
//     if(id != undefined) {
//         todo = props.find(id)
//     }

//     return(
//         <div>
//             {todo == undefined 
//             ? 
//             (<div>Pas de todo avec cet id</div>)
//             :
//             (<div>
//                 {todo.title}<br/>
//                 {todo.content}
//             </div>)
//         }
//         </div>
//     )
// }

class DetailTodo extends Component {
    constructor(props) {
        super(props)
    }

    render() {
        const id = this.props.params.id
        let todo = undefined
        if (id != undefined) {
            todo = this.props.find(id)
        }

        return (
            <div>
                {todo == undefined
                    ?
                    (<div>Pas de todo avec cet id</div>)
                    :
                    (<div>
                        {todo.title}<br />
                        {todo.content}
                    </div>)
                }
                <button onClick={e => this.props.navigate("/")}>Accueil</button>
            </div>
        )
    }
}

export default withNavigate(withParams(DetailTodo))