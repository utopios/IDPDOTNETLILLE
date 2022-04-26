import readline from "readline"
import fs from "fs"
import LineByline from "n-readlines"
//La lecture du contenu d'un fichier async
// fs.readFile("fichier1.txt", (err, data) => {
//     if(err == null)
//         console.log(data.toString())
//     else 
//         console.log(err)
// })

//La lecture du contenu d'un fichier sync
// const data = fs.readFileSync("fichier1.txt")
// console.log(data.toString())

//Ecriture du contenu dans un fichier async
// fs.writeFile('fichier2.txt', "contenu ajouté",(err) => {

// })

//Ecriture du contenu dans un fichier sync
// fs.writeFileSync("fichier3.txt", "contenu fichier 3")

//Ajouter du contenu dans un fichier
// fs.appendFile("fichier.txt", "contenu ajouté", (err) => {
//     console.log(err)
// })

//Une version sync
//fs.appendFileSync("fichier.txt", "\ncontenu fichier")

//pour écouter un fichier
// fs.watchFile("fichier1.txt", (curr, prev) => {
//     //console.log(curr)
//     console.log(fs.readFileSync("fichier1.txt").toString())
//     //console.log(prev)
// })

//Exemple d'écriture de csv
// const nom = "abadi"
// const prenom = "ihab"

// fs.appendFileSync("data.csv", `${nom};${prenom}\n`)
// fs.appendFileSync("data.csv", `${nom};${prenom}\n`)

// const lectureLigneFichier= (fichier) => {
//     const readlineInterface = readline.createInterface({
//         input: fs.createReadStream(fichier),        
//     })
//     return readlineInterface
// }

// lectureLigneFichier("data.csv").on('line', (line) => {
//     console.log(line)
// })

//utilisation du package n-readlines
const lineReader = new LineByline("data.csv")
let line 
while(line = lineReader.next()) {
    console.log(line.toString())
}