import logo from './logo.svg';
import './App.css';
import { Header } from './composants/header';
import { Content } from './composants/content';
import { Footer } from './composants/footer';
import Personne from './composants/personne';
import { ListContacts } from './composants/list-contacts';
import { Compteur } from './Compteur';
function App() {
  return (
    <div className="App">
      {/* <Header></Header>
      <Content></Content>
      <Footer></Footer> */}
      <Personne></Personne>
      {/* <ListContacts /> */}
      <Compteur></Compteur>
    </div>
  );
}

export default App;
