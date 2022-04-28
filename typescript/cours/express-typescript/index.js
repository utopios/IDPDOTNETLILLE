import express from "express";
const app = express();
app.get('/:id', (req, res) => {
    const id = req.params.id;
    res.json({ message: "response" });
});
app.post('data', (req, res) => {
    const p = req.body;
    res.json({ nom: "", prenom: "" });
});
