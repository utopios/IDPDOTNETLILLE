import logo from './logo.svg';
import './App.css';
import { AppTodo } from './components/app-todo';
import {BrowserRouter} from "react-router-dom"
function App() {
  return (
    <div className="App">
      <BrowserRouter>
      <AppTodo></AppTodo>
      </BrowserRouter>
      
    </div>
  );
}

export default App;
