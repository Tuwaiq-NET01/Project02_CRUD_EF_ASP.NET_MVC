import React, {useState} from 'react'
import axios from 'axios'

export default function Games() {
    const [gameName, setGameName] = useState('');
    const [gameDesc, setGameDesc] = useState('');
    const url = 'https://localhost:44384/api/games'

    const getGames = () => {
        axios.get(url)
        .then(res => {
          console.log(res)
        })
        .catch(err => {
          console.error(err); 
        })
      }

      const addGame  = (e) => {
          e.preventDefault();
          let game = {
              GAMmeName : "testFromAxios2222",
              Description: "descesdcscescdec2222"
          }
                    
            axios.post(url,game)
            .then(res => {
            console.log(res)
            })
            .catch(err => {
            console.error(err); 
            })
      }


    return (
        <div>
            <h1>GAMES COMP</h1>

            <button onClick={getGames}>GET GAMES</button>

            <form>


        <div class="mb-3">
  <label for="gameName" class="form-label">Game Name</label>
  <input type="text" class="form-control" id="gameName" onChange={(e) => setGameName(e.target.value)} />
</div>
<div class="mb-3">
  <label for="gameDesc" class="form-label">Example textarea</label>
  <textarea class="form-control" id="gameDesc" rows="3" onChange={(e) => setGameDesc(e.target.value)}></textarea>
</div>



</form>
  <button  class="btn btn-primary" onClick={(e) => addGame(e)}>ADD GAME</button>


        </div>
    )
}
