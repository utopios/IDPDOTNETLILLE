import {useNavigate, useParams} from "react-router-dom"

export const withRouter = (Composant) => (props) => {
    const navigate = useNavigate()
    const params = useParams()
    return <Composant {...props} navigate={navigate} params={params} />
}