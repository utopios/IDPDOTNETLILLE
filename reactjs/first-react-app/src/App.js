import logo from './logo.svg';
import './App.css';
import { Bonjour } from './Bonjour';

const data = [
  {
    nom: "toto", prenom:"tata"
  },
  {
    nom:"titi", prenom: "minet"
  }
]

export function App() {
  return (
    <div className="App">
      <h1>Bonjour tout le monde, cava </h1>
      {/* <Bonjour nom="toto" prenom="titi" />
      <Bonjour nom="tata" prenom="minet" />
      <Bonjour nom="titi" prenom="toto" /> */}
      {
        data.map((element, index) => {
          return(
            <Bonjour nom={element.nom} key={index} prenom={element.prenom} />
          )
        })
      }
    </div>
  );
}


