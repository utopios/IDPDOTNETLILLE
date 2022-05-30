import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import {Routes} from './Routes';
import * as serviceWorker from './serviceWorker';
import 'antd/dist/antd.css';


ReactDOM.render(

    <Routes/>
,
  document.getElementById('root')
);


serviceWorker.unregister();
