import { ADD_POKEDEX, CLEAR_POKEDEX } from '../constants/actionTypes';

const INITIAL_STATE = {
    pokedex: [],

};

function addPokemon(state = INITIAL_STATE, action) {
    switch (action.type) {
        case ADD_POKEDEX: {    
            const newArr = [...state.pokedex];
            newArr.unshift(action.payload)
            return {
                ...state,
                pokedex: newArr,
            }
        };
        case CLEAR_POKEDEX: {
       
            const newArr = [];
            return {
                ...state,
                pokedex: newArr,
            }
        }
    }
    return state;
}

export default addPokemon;