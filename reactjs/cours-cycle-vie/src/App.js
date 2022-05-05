import logo from './logo.svg';
import './App.css';
import { ComponentLife } from './component-life-cycle';
import {useState} from "react"
import { DataComponent } from './data-component';
function App() {
  const [test, setTest] = useState(false)
  return (
    <div className="App">
      {/* <button onClick={e=> setTest(!test)}></button>
      <ComponentLife test={test}></ComponentLife>
      <ComponentLife test={true}></ComponentLife> */}
      <DataComponent/>
    </div>
  );
}

export default App;
