import express, {Express, Request, Response} from "express"
import { IndexRequest } from "./interface/indexRequest"
import { IndexResponse } from "./interface/indexResponse"
import { Personne } from "./interface/Personne"

const app:Express = express()

app.get('/:id', (req:Request<IndexRequest>, res:Response<IndexResponse>) => {
    const id = req.params.id
    res.json({message: "response"})
})

app.post('data', (req:Request<any, any, Personne>, res:Response<Personne>) => {
    const p:Personne = req.body

    res.json({nom:"", prenom:""})
})
