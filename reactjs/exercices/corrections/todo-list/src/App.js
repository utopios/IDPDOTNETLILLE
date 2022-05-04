import logo from './logo.svg';
import './App.css';
import { AppTodo } from './components/app-todo';
import {BrowserRouter, useNavigate} from "react-router-dom"

const FakeBrowser = (props) => {
  const navigate = useNavigate()
  return(
    <AppTodo navigate={navigate}></AppTodo>
  )
}
function App() {
  return (
    <div className="App">
      <BrowserRouter>
      <FakeBrowser></FakeBrowser>
      </BrowserRouter>
      
    </div>
  );
}

export default App;
