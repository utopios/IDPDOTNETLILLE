import logo from './logo.svg';
import './App.css';
import { Header } from './composants/header';
import { Content } from './composants/content';
import { Footer } from './composants/footer';
import Personne from './composants/personne';
function App() {
  return (
    <div className="App">
      {/* <Header></Header>
      <Content></Content>
      <Footer></Footer> */}
      <Personne></Personne>
    </div>
  );
}

export default App;
