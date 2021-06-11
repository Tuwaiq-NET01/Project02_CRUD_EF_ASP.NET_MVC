import React, {useState, useEffect} from 'react'
import axios from 'axios'

export default function Games() {
    const [allGames, setAllGames] = useState([])
    const [gameName, setGameName] = useState('');
    const [gameDesc, setGameDesc] = useState('');
    const [rating, setRating] = useState(0)
    const url = 'https://localhost:44384/api/games'


useEffect(() => {
    axios.get(url)
        .then(res => {
          console.log(res)
          setAllGames(res.data)
        })
        .catch(err => {
          console.error(err); 
        })
        
    return () => {
        // cleanup
    }
}, [])




const addGame  = (e) => {
    e.preventDefault();
    let game = {
        gameName : gameName,
        description: gameDesc,
        rating: rating
    }
              
      axios.post(url,game)
      .then(res => {
      console.log(res)
      })
      .catch(err => {
      console.error("ERR: ", err); 
      })
}




    const deleteGame = (game) => {
        axios.delete(`https://localhost:44384/api/games/${game}`)
.then(res => {
  console.log(res)
  setAllGames(res.data)
})
.catch(err => {
  console.error(err); 
})
    }



    return (
        <div>
            <h1>GAMES COMP</h1>

            <form>


        <div class="mb-3">
  <label for="gameName" class="form-label">Game Name</label>
  <input type="text" class="form-control" id="gameName" onChange={(e) => setGameName(e.target.value)} />
</div>
<div class="mb-3">
  <label for="gameDesc" class="form-label">Example textarea</label>
  <textarea class="form-control" id="gameDesc" rows="3" onChange={(e) => setGameDesc(e.target.value)}></textarea>
</div>

<select class="form-select" aria-label="Default select example" onChange={(e) => setRating(e.target.value)}>
  <option selected>Rating</option>
  <option value="1">One</option>
  <option value="2">Two</option>
  <option value="3">Three</option>
</select>

</form>
  <button  class="btn btn-primary" onClick={(e) => addGame(e)}>ADD GAME</button>


{allGames.map((g) => {
    return(
        <h3>nnn : {g.gameName} <button onClick={() => deleteGame(g.id)}> DELETE </button></h3>
    )
})}

        </div>
    )
}
