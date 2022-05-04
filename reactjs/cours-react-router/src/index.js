import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, useNavigate } from 'react-router-dom';

const root = ReactDOM.createRoot(document.getElementById('root'));


const Browser = () => {
  const navigation = useNavigate()
  return(
      <App navigation={navigation} />
  )
}
root.render(
  <BrowserRouter>
    <Browser />
  </BrowserRouter>

);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
