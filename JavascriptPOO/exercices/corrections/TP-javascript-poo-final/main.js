import { Ihm } from "./classes/ihm.js";

const ihm = new Ihm(document.querySelector("#formulaireRecherche"), document.querySelector("#formulaireAjout"), document.querySelector("#resultat"))
ihm.demarrer()