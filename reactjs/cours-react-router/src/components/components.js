import { Navigate, useNavigate } from "react-router-dom"

export const ComponentA = () => {
    const navigation = useNavigate()
    const redirection = (e) => {
        navigation("/b")
      }
    return(
        <div>
            <h1>Je suis le composant A</h1>
            {/* <button onClick={redirection}>Redirection</button> */}
        </div>
    )
}

export const ComponentB = () => {
    return(
        <div>
            <h1>Je suis le composant B</h1>
        </div>
    )
}