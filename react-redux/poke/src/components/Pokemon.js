import React from 'react';
import { Link } from 'react-router-dom';
import PropTypes from 'prop-types';
import '../styles/Pokemon.css';



export default function Pokemon(props) {
  return (
    <div className="card m-2 d-inline-flex text-center pokemon-card" style={{ width: '10rem' }}>
     <Link to={`/${props.pokemon.id}`}>
       <div className='card-header'>
       <img src={`https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/${props.pokemon.id}.png`}  className="card-img-top" alt="images" />
       </div>
       <p>
         #
         {props.pokemon.id}
       </p>
       <h5 className="name">{props.pokemon.name.toUpperCase()}</h5>
     </Link>
   </div>
  )
}

