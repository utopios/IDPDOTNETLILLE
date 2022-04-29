import logo from './logo.svg';
import './App.css';
import { Header } from './composants/header';
import { Content } from './composants/content';
import { Footer } from './composants/footer';

function App() {
  return (
    <div className="App">
      <Header></Header>
      <Content></Content>
      <Footer></Footer>
    </div>
  );
}

export default App;
