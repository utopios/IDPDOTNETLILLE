/* eslint-disable react/prop-types */
import React, { useEffect } from 'react';
import { Link } from 'react-router-dom';
import { connect, useDispatch } from 'react-redux';
import PropTypes from 'prop-types';
import {getPokemon } from '../redux/actions/actionPokemon';
import '../styles/ShowPokemon.css';
import { useSelector } from 'react-redux';
import { ADD_POKEDEX } from '../redux/constants/actionTypes';

const ShowPokemon = ({ pokemon: { pokemon, loading }, getPokemon, match }) => {

  const pokedex = useSelector((state) => state.addPokemon);

  const dispatch = useDispatch();

  useEffect(() => {
    const { id } = match.params;
    getPokemon(id);
    // eslint-disable-next-line
  }, [loading]);


  const AddPokeDex = () => {
  console.log(pokedex);
    dispatch({
      type: ADD_POKEDEX,
      payload: pokemon,
    });
}

  return pokemon && loading === null ? <h1>loading...</h1> : (
    <div className="row">
      <div className="col-md-6 poke-img d-flex flex-column justify-content-around">
        <h2 className='text-center'>{pokemon.name?.toUpperCase()}</h2>
        <img src={`https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/${pokemon.id}.png`} alt="img" style={{ width: '15rem' }} className="align-self-center" />
        <button className='btn btn-success w-50 align-self-center' onClick={AddPokeDex}> <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" fill="currentColor" class="bi bi-plus-circle-fill" viewBox="0 0 16 16">
  <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM8.5 4.5a.5.5 0 0 0-1 0v3h-3a.5.5 0 0 0 0 1h3v3a.5.5 0 0 0 1 0v-3h3a.5.5 0 0 0 0-1h-3v-3z"/>
</svg> &nbsp; Add</button>
      </div>
      <div className="col-md-6 card poke-card p-4" style={{ width: '35rem' }}>
        <div className="height">
          <h3>HEIGHT</h3>
          <p>{pokemon.height}</p>
        </div>
        <div className="weight">
          <h3>WEIGHT</h3>
          <p>{pokemon.weight}</p>
        </div>
        <div className="experience">
          <h3>XP</h3>
          <p>{pokemon.base_experience}</p>
        </div>
        <div className="abilities">
          <h3>ABILITIES</h3>
          {pokemon.abilities ? pokemon.abilities.map(ab => <span className="ability" key={ab.ability.name}>{ab.ability.name}</span>) : 'undefined'}
        </div>
        <div className="types">
          <h3>Type</h3>
          {pokemon.types ? pokemon.types.map(type => <span className="type" key={type.type.name}>{type.type.name}</span>) : 'undefined'}
        </div>
      </div>
      <div className="moves mt-3 p-2 card">
        <h3>MOVES</h3>
        <div className="list-moves">
          {pokemon.moves ? pokemon.moves.map(move => <span className="move" key={move.move.name}>{move.move.name}</span>) : 'undefined'}
        </div>
      </div>
      <Link to="/" className="text-center"><button type="button" className="btn btn-primary"> <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" fill="currentColor" class="bi bi-arrow-return-left" viewBox="0 0 16 16">
        <path fill-rule="evenodd" d="M14.5 1.5a.5.5 0 0 1 .5.5v4.8a2.5 2.5 0 0 1-2.5 2.5H2.707l3.347 3.346a.5.5 0 0 1-.708.708l-4.2-4.2a.5.5 0 0 1 0-.708l4-4a.5.5 0 1 1 .708.708L2.707 8.3H12.5A1.5 1.5 0 0 0 14 6.8V2a.5.5 0 0 1 .5-.5z" />
      </svg> &nbsp; Back to list</button></Link>
    </div>
  );
};


const mapStateToProp = state => ({
  pokemon: state.pokemon,
});

export default connect(mapStateToProp, { getPokemon })(ShowPokemon);
