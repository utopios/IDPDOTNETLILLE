import DetailPersonne from "./detail-personne";
import FormPersonne from "./form-personne";
import {Component} from "react"
class Personne extends Component {
    constructor(props) {
        super(props);
    }
    render() { 
        return ( <div>
            <FormPersonne/>
            <DetailPersonne/>
        </div> );
    }
}
 
export default Personne;