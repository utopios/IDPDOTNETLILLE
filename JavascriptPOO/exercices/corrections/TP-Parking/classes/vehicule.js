export class Vehicule {

    constructor(immatriculation) {
        this.dateIn = new Date()
        this.immatriculation = immatriculation
    }

    //Le temps dans le parking
    getTime() {
        const dateOut = new Date()
        console.log(dateOut)
        console.log(this.dateIn)
        return ((dateOut - this.dateIn)/1000)
    }
}