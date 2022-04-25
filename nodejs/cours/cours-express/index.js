import express from "express"

const app = express()

app.get('', (req, res) => {
    res.end("<h1>Hello from our first nodejs app</h1>")
    //res.json(req.headers)
})

app.get('/clients', (req, res) => {
    res.json([
        {nom : 'toto', prenom: 'tata'},
        {nom : 'minet', prenom: 'titi'},
    ])
})
//pour démarrer notre application web sur un port donné.
app.listen(3000, () => {
    console.log("Démarrage de l'application")
})