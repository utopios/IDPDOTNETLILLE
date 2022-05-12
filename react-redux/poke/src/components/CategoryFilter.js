import React from 'react';
import PropTypes from 'prop-types';
import types from '../redux/constants/types';




export default function CategoryFilter(props) {
  return (
    <div className="text-center w-100">
     <select name="type" onChange={props.handleChange} className="w-25">
       <option value="ALL">Selectionner une catégorie</option>
       { types.map(type => (
         <option key={type} value={type}>
           { type }
         </option>
       ))}
     </select>
   </div>
  )
}
