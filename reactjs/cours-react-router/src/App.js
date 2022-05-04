import logo from './logo.svg';
import './App.css';
import { Routes, Route, BrowserRouter, Link, Navigate, Outlet } from "react-router-dom"
import { ComponentA, ComponentB, ComponentParams } from './components/components';
import { Component } from 'react';
// function App() {
//   return (
//     <BrowserRouter>
//       <div className="App">
//         <header className="App-header">
//           <h1>Cours react router dom v6</h1>
//           <nav>
//             <Link to="/">Home</Link>
//             <Link to="/a">A</Link>
//             <Link to="/b">B</Link>
//           </nav>
//         </header>
//         <Routes>
//           <Route path='/a' element={<ComponentA />}></Route>
//           <Route path='/b' element={<ComponentB />}></Route>
//         </Routes>
//       </div>
//     </BrowserRouter>
//   );
// }


class App extends Component {
  constructor(props) {
    super(props)
    this.state = {
      liens : [1, 2, 3]
    }
  }

  redirection = (e) => {
    
    this.props.navigation("/b")
  }
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <h1>Cours react router dom v6</h1>
          <nav>
            <Link to="/">Home</Link>
            <Link to="/a">A</Link>
            <Link to="/b">B</Link>
            {this.state.liens.map((e,i) => (<Link to={"/avec-param/"+e} key={i}>{e}</Link>))}
          </nav>
          <button onClick={this.redirection}>Redirection</button>
        </header>
        <Routes>
          <Route path='/a' element={<ComponentA />}></Route>
          <Route path='/avec-param/:id' element={<ComponentParams/>}></Route>
          <Route path='/b' element={<ComponentB />}></Route>
        </Routes>
      </div>      
    )
  }
}
export default App;
