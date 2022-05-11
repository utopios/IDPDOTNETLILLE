import logo from './logo.svg';
import './App.css';
import { useEffect, useState } from 'react';
import Affiche from './Affiche';

function App() {

  const [toogle, setToogle] = useState(true);

  // const [etat, setEtat] = useState(0);
  // const [etat1, setEtat1] = useState(0);
  // const [etat2, setEtat2] = useState(0);


  // useEffect(() => {
  //   console.log("change etat2")
  // }, [etat])

  // const changeEtat = () => {

  //   setEtat2(etat2 + 1);

  // }

  const afficheFunc = () => {
    setToogle(!toogle);
  }

  return (
    <div className="App">

      {/* <h1>Etat : {etat} </h1>

      <button onClick={changeEtat}>Change</button> */}


     { toogle && <Affiche />}
      <button onClick={afficheFunc} >Print</button>

    </div>
  );
}

export default App;
