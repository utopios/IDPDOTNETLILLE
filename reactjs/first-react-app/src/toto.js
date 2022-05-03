import {useState} from "react"
export const Toto = (props) => {
    const [first, setFirst] = useState()
    return(
        <div>
            {first}
            <input type="text" onChange={(e) => setFirst(e.target.value)} />
        </div>
    )
}

// export class Toto extends Component {
//     constructor(props) {
//         super(props) 
//         this.state = {
//             first: "default value"
//         }
//     }
// }