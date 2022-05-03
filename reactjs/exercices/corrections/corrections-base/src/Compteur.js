import {useState} from "react"
export const Compteur = (props) => {
    const [count, setCount] = useState(0)

    return(
        <div>
            <button disabled={count == 0} onClick={(e) => setCount(count-1)}>-</button>
            {count}
            <button onClick={(e) => setCount(count+1)}>+</button>
        </div>
    )
}