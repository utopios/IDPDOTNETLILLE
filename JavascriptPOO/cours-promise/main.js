const p = new Promise((resolve, reject) => {
    //Logique métier dans la promise
    let test = false
    setTimeout(() => {
        if(test) {
            resolve({data : "les données envoyées par la promise"})
        }
        else {
            reject({message: "Message d'erreur en cas d'echec de la promise"})
        }
    },5000)
})

//Flux d'execution

p.then((response) => {
    result.innerHTML = response.data
}).catch(err => {
    result.innerHTML = err.message
})

const result = document.querySelector("#result")
result.innerHTML = "En cours d'execution"