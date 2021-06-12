import React, {useState, useEffect} from 'react'
import axios from 'axios'
import {BsFillStarFill} from 'react-icons/bs';
import DisplayGames from './DisplayGames';


export default function Games() {
    const [allGames, setAllGames] = useState([])
    const [gameName, setGameName] = useState('');
    const [gameImage, setGameImage] = useState('');
    const [gameDesc, setGameDesc] = useState('');
    const [rating, setRating] = useState(1);
    const [loading, setLoading] = useState(true);
    const url = 'https://localhost:44384/api/games'


useEffect(() => {
    axios.get(url)
        .then(res => {
          console.log(res)
          setAllGames(res.data)
          setLoading(false);
        })
        .catch(err => {
          console.error(err); 
        })
        
    return () => {
        // cleanup
    }
}, [])




const addGame  = (e) => {
    // e.preventDefault();
    let game = {
        gameName : gameName,
        image: gameImage,
        description: gameDesc,
        rating: rating
    }
              
      axios.post(url,game)
      .then(res => {
      console.log(res)
      setAllGames(res.data)
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
        <div className="container">

            <h1>GAMES COMP</h1>


<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
  Add New Game
</button>

<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Add New Game</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">



      <form>


<div class="mb-3">
<label for="gameName" class="form-label">Game Name: </label>
<input type="text" class="form-control" id="gameName" onChange={(e) => setGameName(e.target.value)} />
</div>
<div class="mb-3">
<label for="gameImage" class="form-label">Game Image: </label>
<input type="text" class="form-control" id="gameImage" onChange={(e) => setGameImage(e.target.value)} />
</div>
<div class="mb-3">
<label for="gameDesc" class="form-label">Description: </label>
<textarea class="form-control" id="gameDesc" rows="3" onChange={(e) => setGameDesc(e.target.value)}></textarea>
</div>

<div class="form-check">
<input class="form-check-input" type="radio" name="ratingRadio" value="1" id="flexRadioDefault1" onChange={(e)=> setRating(e.target.value)} checked/>
<label class="form-check-label" for="flexRadioDefault1">
<BsFillStarFill />
</label>
</div>
<div class="form-check">
<input class="form-check-input" type="radio" name="ratingRadio" value="2"  id="flexRadioDefault2" onChange={(e)=> setRating(e.target.value)} />
<label class="form-check-label" for="flexRadioDefault2">
<BsFillStarFill /> <BsFillStarFill />
</label>
</div>
<div class="form-check">
<input class="form-check-input" type="radio" name="ratingRadio" value="3"  id="flexRadioDefault3" onChange={(e)=> setRating(e.target.value)} />
<label class="form-check-label" for="flexRadioDefault3">
<BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill />
</label>
</div>
<div class="form-check">
<input class="form-check-input" type="radio" name="ratingRadio" value="4"  id="flexRadioDefault4" onChange={(e)=> setRating(e.target.value)} />
<label class="form-check-label" for="flexRadioDefault4">
<BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill />
</label>
</div>
<div class="form-check">
<input class="form-check-input" type="radio" name="ratingRadio" value="5"  id="flexRadioDefault5" onChange={(e)=> setRating(e.target.value)} />
<label class="form-check-label" for="flexRadioDefault5">
<BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill />
</label>
</div>



</form>


</div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="submit" class="btn btn-primary" data-bs-dismiss="modal" onClick={(e) => addGame(e)}>ADD GAME</button>
      </div>
    </div>

  </div>
</div>


{loading ? (
    <div class="d-flex justify-content-center mt-5">
    <div
      class="spinner-border"
      style={{ width: " 10rem", height: "10rem" }}
      role="status"
    >
      <span class="visually-hidden">Loading...</span>
    </div>
  </div>
        
        ) : (
            <DisplayGames allGames={allGames} deleteGame={deleteGame}/>  
        )}

           






        </div>
    )
}
