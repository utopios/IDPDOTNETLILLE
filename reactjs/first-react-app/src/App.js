import logo from './logo.svg';
import './App.css';
import { Bonjour } from './Bonjour';
import {Component} from "react"
import { Toto } from './toto';
export class App extends Component {
  
  constructor(props) {
    super(props)
    this.state = {
      data: [
        {
          nom: "toto", prenom: "tata"
        },
        {
          nom: "titi", prenom: "minet"
        }
      ],
      count : 0
    }
  }
  clickButton = (e) => {
   this.setState({
    data : [...this.state.data, {nom:"bb", prenom:"tt"}],
    count: this.state.count + 1
    })
    
  }

  changeCountInput = (e) => {
   
    this.setState({count: e.target.value})
  }
  render() {
    return (
      <div className="App">
        <div><input defaultValue={this.state.count} onChange={this.changeCountInput}  /></div>
        <h1>{this.state.count}</h1>

        <button onClick={this.clickButton}>valider</button>
        <h1>Bonjour tout le monde, cava </h1>
        {/* <Bonjour nom="toto" prenom="titi" />
      <Bonjour nom="tata" prenom="minet" />
      <Bonjour nom="titi" prenom="toto" /> */}
        {
          this.state.data.map((element, index) => {
            return (
              <Bonjour nom={element.nom} key={index} prenom={element.prenom} />
            )
          })
        }
        <Toto></Toto>
      </div>
    )
  }
}



