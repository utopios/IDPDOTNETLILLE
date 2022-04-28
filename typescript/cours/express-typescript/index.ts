import express, {Express, Request, Response} from "express"
import { IndexRequest } from "./interface/indexRequest"
import { IndexResponse } from "./interface/indexResponse"

const app:Express = express()

app.get('/:id', (req:Request<IndexRequest>, res:Response<IndexResponse>) => {
    const id = req.params.id
    res.json({message: "response"})
})
