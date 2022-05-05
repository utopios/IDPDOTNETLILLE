import logo from './logo.svg';
import './App.css';
import { ComponentLife } from './component-life-cycle';
import {useState} from "react"
function App() {
  const [test, setTest] = useState(false)
  return (
    <div className="App">
      <button onClick={e=> setTest(!test)}></button>
      <ComponentLife test={test}></ComponentLife>
      <ComponentLife test={true}></ComponentLife>
    </div>
  );
}

export default App;
