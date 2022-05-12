import { combineReducers } from 'redux';
import pokemon from './pokemon';
import filter from './filter';
import addPokemon from './addPokemon';

export default combineReducers({ pokemon, filter, addPokemon});
