import React from 'react'
import { useDispatch, useSelector } from 'react-redux'
import "../styles/Header.css"
import Modal from 'react-modal';
import { CLEAR_POKEDEX } from '../redux/constants/actionTypes';

export default function Header() {

    const pokedex = useSelector((state) => state.addPokemon);

    const dispatch = useDispatch();

    const customStyles = {
        content: {
            top: '50%',
            left: '50%',
            right: 'auto',
            bottom: 'auto',
            marginRight: '-50%',
            transform: 'translate(-50%, -50%)',
            width: "300px",
        },
    };


    let subtitle;
    const [modalIsOpen, setIsOpen] = React.useState(false);

    function openModal() {
        setIsOpen(true);
    }

    function closeModal() {
        setIsOpen(false);
    }

    function clear() {
        dispatch({
            type: CLEAR_POKEDEX,
        });
    }

    return (

        <>
            <nav class="navbar navbar-expand-lg navbar-dark bg-dark">


                <img src={`https://upload.wikimedia.org/wikipedia/commons/9/98/International_Pok%C3%A9mon_logo.svg`} style={{ width: '100px' }} className="mr-4" />

                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav d-flex flex-row justify-content-between w-100">
                        <li class="nav-item active d-flex flex-column justify-content-center">
                            <a class="nav-link" href="https://www.pokemon.com/fr/"> <h3>Home</h3> <span class="sr-only">(current)</span></a>
                        </li>
                        <li class="nav-item d-flex flex-column justify-content-center">
                            <h3 class="nav-link" href="#">Mon Pokedex</h3>
                        </li>

                        <li class="nav-item d-flex flex-row" >
                            <div className="d-flex flex-column justify-content-center col-2">
                                <span className='d-flex flex-row justify-content-center'> <img src={require('../assets/pokeball.png')} style={{ width: '30px', height: '30px' }} className="align-self-center" /> &nbsp; &nbsp;  <div className='h4 d-flex flex-column justify-content-center'><b>{pokedex.pokedex.length}</b></div>
                                </span>  <small className='align-self-center'>Pokeball</small>
                            </div>
                            <div className="d-flex flex-column justify-content-start col-5">
                                <button className="btn btn-danger text-center w-100 px-4" onClick={clear}><svg xmlns="http://www.w3.org/2000/svg" width="22" height="22" fill="currentColor" class="bi bi-x" viewBox="0 0 16 16">
                                    <path d="M4.646 4.646a.5.5 0 0 1 .708 0L8 7.293l2.646-2.647a.5.5 0 0 1 .708.708L8.707 8l2.647 2.646a.5.5 0 0 1-.708.708L8 8.707l-2.646 2.647a.5.5 0 0 1-.708-.708L7.293 8 4.646 5.354a.5.5 0 0 1 0-.708z" />
                                </svg>&nbsp;&nbsp;&nbsp;Clear</button>
                            </div>
                            <div className="col-5">
                                <button onClick={openModal} className="btn btn-primary w-100"><svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" fill="currentColor" class="bi bi-arrows-fullscreen" viewBox="0 0 16 16">
                                    <path fill-rule="evenodd" d="M5.828 10.172a.5.5 0 0 0-.707 0l-4.096 4.096V11.5a.5.5 0 0 0-1 0v3.975a.5.5 0 0 0 .5.5H4.5a.5.5 0 0 0 0-1H1.732l4.096-4.096a.5.5 0 0 0 0-.707zm4.344 0a.5.5 0 0 1 .707 0l4.096 4.096V11.5a.5.5 0 1 1 1 0v3.975a.5.5 0 0 1-.5.5H11.5a.5.5 0 0 1 0-1h2.768l-4.096-4.096a.5.5 0 0 1 0-.707zm0-4.344a.5.5 0 0 0 .707 0l4.096-4.096V4.5a.5.5 0 1 0 1 0V.525a.5.5 0 0 0-.5-.5H11.5a.5.5 0 0 0 0 1h2.768l-4.096 4.096a.5.5 0 0 0 0 .707zm-4.344 0a.5.5 0 0 1-.707 0L1.025 1.732V4.5a.5.5 0 0 1-1 0V.525a.5.5 0 0 1 .5-.5H4.5a.5.5 0 0 1 0 1H1.732l4.096 4.096a.5.5 0 0 1 0 .707z" />
                                </svg>&nbsp;&nbsp;&nbsp;Show</button>
                                <Modal
                                    isOpen={modalIsOpen}
                                    onRequestClose={closeModal}
                                    style={customStyles}
                                    contentLabel="Example Modal"
                                >
                                    <h2 className="text-center">Ma PokeBall</h2>
                                    <div>{pokedex.pokedex.map((poke) => {

                                        return (
                                            <span class="alert alert-primary d-flex flex-row justify-content-around w-100" role="alert">
                                                <div> {<img src={`https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/${poke.id}.png`} alt="img" style={{ width: '3rem' }} className="align-self-center" />}</div>
                                                &nbsp; &nbsp;
                                                <div><small><b>Name</b> </small><div>{poke.name}</div></div>
                                                &nbsp; &nbsp;
                                                <div><small><b>Height</b></small><div>{poke.height}</div></div>
                                                &nbsp; &nbsp;
                                                <div><small><b>Weight</b></small><div>{poke.weight}</div></div>
                                                &nbsp; &nbsp;
                                            </span>
                                        );
                                    })

                                    }</div>
                                    <button onClick={closeModal} className="btn btn-primary w-50">close</button>

                                </Modal></div>
                        </li>

                    </ul>
                </div>
            </nav>

        </>


    )
}
