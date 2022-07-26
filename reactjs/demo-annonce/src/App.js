import logo from './logo.svg';
import './App.css';
import {useState} from "react"

import axios from "axios"

const App = () => {
  
  const [annonces, setAnnonces] = useState([])
  const getAnnonces = () => {
    axios.get("http://localhost:5164/api/v1/annonce", {headers:{"Authorization": ""}}).then(res => {
      setAnnonces(res.data)
    })
  }
  
  return (
    <div className="App">
      <button onClick={getAnnonces}>get annonces</button>
      {annonces.map((annonce, index) =>  (
        <div key={index}>
          {annonce.titre}
        </div>
      ))}
    </div>
  );
}

export default App;
