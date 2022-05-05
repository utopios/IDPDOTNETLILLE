const data = ["toto","tata", "titi"]

export const getData = () => new Promise((resole, reject) => {
    setTimeout(() => {
        resole(data)
    }, 5000)
})