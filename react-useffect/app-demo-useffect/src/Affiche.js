import React, { useEffect } from 'react'

export default function Affiche() {


    useEffect(() => {

        console.log("Coucou");

        return () => {
           console.log("Destruction ..");
        }

    }, [    ])


    return (
        <h1>Affiche</h1>
    )
}
