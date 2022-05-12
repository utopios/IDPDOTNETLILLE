import './App.css';
import "./App.css";
import Home from "./Containers/Home/Home";
import AddArticle from "./Containers/AddArticle/AddArticle";
import Contact from "./Containers/Contact/Contact";
import Article from "./Containers/Article/Article";
import Navbar from './Components/Navbar/Navbar'
import { BrowserRouter as Routes, Switch, Route} from "react-router-dom";
function App() {
  return (
    <>

      <Routes>
        <Navbar />
          <Route path="/" exact component={Home} />
          <Route path="/ecrire" exact component={AddArticle} />
          <Route path="/contact" exact component={Contact} />
          <Route path="/article" exact component={Article} />   
      </Routes>
    </>

  );
}

export default App;
