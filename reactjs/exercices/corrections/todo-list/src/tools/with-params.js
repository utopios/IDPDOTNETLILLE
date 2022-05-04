import { useParams } from "react-router-dom"

export const WithParams = (Composant) => props => {
    const params = useParams()
    return (<Composant {...props} params={params} />)
}    