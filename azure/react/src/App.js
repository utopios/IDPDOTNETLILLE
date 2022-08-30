import logo from './logo.svg';
import './App.css';
import { Bonjour } from './Bonjour';
import { Component } from "react"
import { Toto } from './toto';
import axios from "axios"
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
      count: 0,
      dataApi: []
    }
  }
  clickButton = (e) => {
    this.setState({
      data: [...this.state.data, { nom: "bb", prenom: "tt" }],
      count: this.state.count + 1
    })

  }

  componentDidMount() {
    const url = process.env.REACT_APP_API

    axios.get(url + "demo").then(res => {
      this.setState(
        { dataApi: res.data }
      )
    })
  }
  changeCountInput = (e) => {

    this.setState({ count: e.target.value })
  }
  render() {
    return (
      <div className="App">
        <div><input defaultValue={this.state.count} onChange={this.changeCountInput} /></div>
        <div>
          <h1>Data from api 2</h1>
          {this.state.dataApi.map((element, index) => (<div key={index}>{element}</div>))}
        </div>
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



