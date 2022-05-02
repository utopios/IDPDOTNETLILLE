import {Component} from "react"
import { Contact } from "./contact";
export class ListContacts extends Component {
    // contacts = [
    //     {nom : "nom contact 1", prenom: "prenom contact 1", telephone:"0101010101", email:"contact1@fr"},
    //     {nom : "nom contact 2", prenom: "prenom contact 2", telephone:"0101010102", email:"contact2@fr"},
    //     {nom : "nom contact 2", prenom: "prenom contact 2", telephone:"0101010102", email:"contact2@fr"},
    // ]
    constructor(props) {
        super(props);
        this.state = {
            contacts : [
                {nom : "nom contact 1", prenom: "prenom contact 1", telephone:"0101010101", email:"contact1@fr"},
                {nom : "nom contact 2", prenom: "prenom contact 2", telephone:"0101010102", email:"contact2@fr"},
                {nom : "nom contact 2", prenom: "prenom contact 2", telephone:"0101010102", email:"contact2@fr"},
            ]
        }
    }
    render() { 
        return (  
            // this.contacts.map((c, i) => (<Contact key={i} nom={c.nom} prenom={c.prenom} telephone={c.telephone} email={c.email} />))
            this.state.contacts.map((c, i) => (<Contact key={i} contact={c}/>))
        );
    }
}
