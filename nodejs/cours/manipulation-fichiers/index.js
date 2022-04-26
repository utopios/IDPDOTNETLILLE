import fs from "fs"

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
fs.watchFile("fichier1.txt", (curr, prev) => {
    //console.log(curr)
    console.log(fs.readFileSync("fichier1.txt").toString())
    //console.log(prev)
})