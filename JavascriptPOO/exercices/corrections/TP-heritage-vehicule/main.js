import { Moto } from "./classes/moto.js";
import { Voiture } from "./classes/voiture.js";

const kangoo = new Voiture('renault', 'kangoo', '240000', '2003', true)

const motoR = new Moto("BMW", "1150R", "65000", "2005")

const result =document.querySelector("#result")

result.innerHTML += kangoo.display()
result.innerHTML += "<br>"
result.innerHTML += motoR.display()