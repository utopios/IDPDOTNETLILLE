/* eslint-disable react/forbid-prop-types */
import React, { useEffect, useState } from 'react';
import { getPokemons, changeFilter, getPokes } from '../redux/actions/actionPokemon';
import Pokemon from '../components/Pokemon';
import CategoryFilter from '../components/CategoryFilter';
import { connect } from 'react-redux';



const PokemonList = ({getPokemons, pokemons, changeFilter, filter}) => {


  useEffect(() => {
    getPokemons();
    // eslint-disable-next-line
  }, []);

  const handleFilterChange = e => {
    const { value } = e.target;
    changeFilter(value);
  };

  const filteredPokemons = () => (filter === 'ALL' ? pokemons : pokemons.filter(pokemon => {
  

    const arr = pokemon.types;

    for (let i = 0; i < arr.length; i += 1) {
      if (arr[i].type.name === filter) return true;
    }
    return false;
  }));

  return pokemons === null ? <h1>Loading....</h1> : (
    <>

      <CategoryFilter handleChange={handleFilterChange} className="mt-4 pt-4"/>
      <div className='d-flex flex-wrap justify-content-center'>
        {filteredPokemons().map(pokemon => (
          <Pokemon key={pokemon.id} pokemon={pokemon} />
        ))}
      </div>

    </>

  );
};
const mapStateToProps = state => ({
  pokemons: state.pokemon.pokemons,
  filter: state.filter,
});
// permet la connexion au store de notre composant PokemonList + recupérattion du state global dans mon store avec mapStateToProps
// avec mapStateToProps 
// getPokemons => methode dispatch modification liste pokemon (methode présente dans actionPokemon )
// changeFilter => methode dispatch mise à jour du filtre (methode présente dans actionPokemon )
export default connect(mapStateToProps, { getPokemons, changeFilter })(PokemonList);


