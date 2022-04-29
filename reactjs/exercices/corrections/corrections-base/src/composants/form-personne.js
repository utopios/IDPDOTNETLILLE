import {Component} from "react"
class FormPersonne extends Component {
    constructor(props) {
        super(props);
    }
   
    render() { 
        return ( 
            <form>
                <div>
                    <input type="text" placeholder="Nom " />
                </div>
                
                <div>
                    <input type="text" placeholder="Prénom " />
                </div>
                <div>
                    <button type='submit'>Valider</button>
                </div>
            </form>
         );
    }
}
 
export default FormPersonne;