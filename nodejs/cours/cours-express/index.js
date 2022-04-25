import express from "express"

const app = express()

const data = []


app.use(express.json())

app.get('', (req, res) => {
    res.end("<h1>Hello from our first nodejs app</h1>")
    //res.json(req.headers)
})

app.get('/data/:nomparams', (req, res) => {
    res.end(req.params.nomparams)
})

app.get('/data', (req, res) => {
    res.json(data)
})

app.post('', (req, res) => {
    data.push(req.body)
    res.json(req.body)
})
//pour démarrer notre application web sur un port donné.
app.listen(3000, () => {
    console.log("Démarrage de l'application")
})