export class Jeu {
    constructor() {
        this.board = []
        for(let i=1; i <= 3; i++) {
            this.board = [...this.board, [' ', ' ', ' ']]
        }
    }

    afficher() {
        for(let i=0; i < this.board.length; i++) {
            let ligne = ''
            for(let j=0; j < this.board[i].length; j++) {
                ligne += '|'+ this.board[i][j] + '|' 
            }
            console.log(ligne)
            console.log('---------')
        }
    }

    jouer(joueur, x, y) {
        if(this.board[x-1][y-1] == ' ') {
            this.board[x-1][y-1] = joueur
            return true
        }
        return false
    }
}