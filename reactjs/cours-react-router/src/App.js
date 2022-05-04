import logo from './logo.svg';
import './App.css';
import { Routes, Route, BrowserRouter, Link } from "react-router-dom"
import { ComponentA, ComponentB } from './components/components';
function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <header className="App-header">
          <h1>Cours react router dom v6</h1>
          <nav>
            <Link to="/">Home</Link>
            <Link to="/a">A</Link>
            <Link to="/b">B</Link>
          </nav>
        </header>
        <Routes>
          <Route path='/a' element={<ComponentA />}></Route>
          <Route path='/b' element={<ComponentB />}></Route>
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
