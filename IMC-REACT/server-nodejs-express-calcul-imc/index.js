const express = require("express");
const cors = require("cors");

const bodyParser = require("body-parser");
const app = express();
const fs = require("fs");
app.use((req, res, next) => {
  res.header("Access-Control-Allow-Origin", "*");
  res.header("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
  res.header("Access-Control-Allow-Headers", "*");
  next();
});

app.use(bodyParser.json());
app.use(cors());

app.listen(3001, function() {
  console.log("connexion ok");
});

const getUsers = () => {
  const contentUsersJson = fs.readFileSync("user.json");
  const users = JSON.parse(contentUsersJson);
  return users;
};

const getImc = () => {
  const contentImc = fs.readFileSync("imc.json");
  const imcs = JSON.parse(contentImc);
  return imcs;
};

const getEtat = () => {
  const contentEtat = fs.readFileSync("etat.json");
  const etats = JSON.parse(contentEtat);
  return etats;
};
const saveUsers = data => {
  fs.writeFileSync("user.json", JSON.stringify(data));
};
const saveImc = data => {
  fs.writeFileSync("imc.json", JSON.stringify(data));
};

app.post("/creation", (req, res) => {
  const infosCreation = req.body;
  const user = {
    nom: infosCreation.nom,
    mdp: infosCreation.mdp,
    age: infosCreation.age,
    taille: infosCreation.taille
  };
  const date1 = new Date();
  const date = date1.toDateString();
  const imc = {
    nom: infosCreation.nom,
    mdp: infosCreation.mdp,
    poids: infosCreation.poids,
    date: date
  };
  const userExist = getUsers().find(element => element.nom == user.nom);
  if (userExist == undefined) {
    const tmpUsers = [...getUsers(), user];
    const tmpImc = [...getImc(), imc];
    saveImc(tmpImc);
    saveUsers(tmpUsers);
    result = "user created";
  } else {
    result = "user exist";
  }
  return res.json({ msg: result });
});

app.get("/delete-imc/:userNom/:date", (req, res) => {
  const imcsToNotDelete = getImc().filter(
    imc => imc.nom != req.params.userNom || imc.date != req.params.date
  );
  console.log(req.params.userNom);
  console.log(req.params.date);
  console.log(imcsToNotDelete);
  saveImc(imcsToNotDelete);
  res.json({ msg: "Donnée suprimée", isDelete: true });
});

app.get("/users", (req, res) => {
  res.json(getUsers());
});

app.get("/etat", (req, res) => {
  res.json(getEtat());
});

app.get("/imcs/:userName", (req, res) => {
  const imcsUser = getImc().filter(imc => imc.nom == req.params.userName);
  res.json(imcsUser);
});

app.post("/identification", (req, res) => {
  const user1 = req.body;
  const userExist1 = getUsers().find(element => element.nom == user1.nom);
  if (userExist1 == undefined) {
    result1 = "identifiant non trouvé";
  } else if (userExist1.nom == user1.nom && userExist1.mdp == user1.mdp) {
    result1 = "connexion valide";
  } else if (userExist1.nom == user1.nom && userExist1.mdp != user1.mdp) {
    result1 = "erreur mdp";
  }

  return res.json({ msg: result1 });
});

app.post("/form", (req, res) => {
  const imc = req.body;
  const date1 = imc.date;
  const date2 = new Date(date1);
  const date = date2.toDateString();
  const imc2 = {
    nom: imc.nom,
    mdp: imc.mdp,
    poids: imc.poids,
    date: date
  };
  const tmpImc = [...getImc(), imc2];
  saveImc(tmpImc);
  result = "poids enregistre";
  return res.json({ msg: result });
});

app.get("/listImcUser/:userName", (req, res) => {
  const listImc = calculListImc(req.params.userName);
  res.json(listImc);
});

calculListImc = nom => {
  console.log(nom)
  let taille;
  let tableauImcComplet = [];
  const user = getUsers().find(element => element.nom == nom);
  const listUserImc = getImc().filter(imc => imc.nom == nom);
  console.log(listUserImc)
  const listEtat = getEtat();
  console.log(listEtat)
  taille = user.taille;
  console.log(taille)
  for (let imc of listUserImc) {
    let indice = Math.round(imc.poids / ((taille / 100) * (taille / 100)));
    let etat1;
    let description;
    let color;
    let taille1;
    let effort;
    if (indice <= 18) {
      for (let etat of listEtat) {
        if (etat.etat == "Maigreur") {
          etat1 = etat.etat;
          description = etat.description;
          color = etat.color;
          taille1 = etat.taille;
          effort = Math.round(
            imc.poids - 18 * ((taille / 100) * (taille / 100))
          );
        }
      }
    } else if (indice > 18 && indice <= 25) {
      for (let etat of listEtat) {
        if (etat.etat == "Normal") {
          etat1 = etat.etat;
          description = etat.description;
          color = etat.color;
          taille1 = etat.taille;
          effort = 0;
        }
      }
    }else if (indice > 25 && indice <= 30) {
      for (let etat of listEtat) {
        if (etat.etat == "Surpoids") {
          etat1 = etat.etat;
          description = etat.description;
          color = etat.color;
          taille1 = etat.taille;
          effort = Math.round(
            imc.poids - 25 * ((taille / 100) * (taille / 100))
          );
        }
      }
    } else if (indice > 30 && indice <= 40) {
      for (let etat of listEtat) {
        if (etat.etat == "Obésité") {
          etat1 = etat.etat;
          description = etat.description;
          color = etat.color;
          taille1 = etat.taille;
          effort = Math.round(
            imc.poids - 25 * ((taille / 100) * (taille / 100))
          );
        }
      }
    } else if (indice > 40) {
      for (let etat of listEtat) {
        if (etat.etat == "O.Morbide") {
          etat1 = etat.etat;
          description = etat.description;
          color = etat.color;
          taille1 = etat.taille;
          effort = Math.round(
            imc.poids - 25 * ((taille / 100) * (taille / 100))
          );
        }
      }
    }
    let obj = {
      nom: imc.nom,
      poids: imc.poids,
      date: imc.date,
      indice: indice,
      etat: etat1,
      description: description,
      color: color,
      taille: taille1,
      effort: effort
    };
    console.log(obj);
    tableauImcComplet.push(obj);
  }
  return tableauImcComplet;
};

