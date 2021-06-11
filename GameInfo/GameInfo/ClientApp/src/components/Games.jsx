import React, {useState, useEffect} from 'react'
import axios from 'axios'
import {BsFillStarFill} from 'react-icons/bs';


export default function Games() {
    const [allGames, setAllGames] = useState([])
    const [gameName, setGameName] = useState('');
    const [gameDesc, setGameDesc] = useState('');
    const [rating, setRating] = useState(1)
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
        <div className="container">

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
{/* ={{ color: 'blue', size: '50px' }} */}
{/* <select class="form-select" aria-label="Default select example" onChange={(e) => setRating(e.target.value)}>
  <option selected>Rating</option>
  <option value="1"> aaaaaa <BsFillStarFill /> </option>
  <option value="2"><BsFillStarFill /> <BsFillStarFill /></option>
  <option value="3"><BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill /></option>
</select> */}

<div onChange={(e)=> setRating(e.target.value)}> 
<div class="form-check">
  <input class="form-check-input" type="radio" name="ratingRadio" value="1" id="flexRadioDefault1" checked/>
  <label class="form-check-label" for="flexRadioDefault1">
  <BsFillStarFill />
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="radio" name="ratingRadio" value="2"  id="flexRadioDefault2"  />
  <label class="form-check-label" for="flexRadioDefault2">
    <BsFillStarFill /> <BsFillStarFill />
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="radio" name="ratingRadio" value="3"  id="flexRadioDefault3"  />
  <label class="form-check-label" for="flexRadioDefault3">
    <BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill />
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="radio" name="ratingRadio" value="4"  id="flexRadioDefault4"  />
  <label class="form-check-label" for="flexRadioDefault4">
    <BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill />
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="radio" name="ratingRadio" value="5"  id="flexRadioDefault5"  />
  <label class="form-check-label" for="flexRadioDefault5">
    <BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill /> <BsFillStarFill />
  </label>
</div>
</div>

</form>
  <button  class="btn btn-primary" onClick={(e) => addGame(e)}>ADD GAME  </button>

  <i class="fas fa-star fa-2x"></i>



<div className="row">{allGames.map((ga, i) => {
    return (
              <div className="col-md-3 mt-5" key={i}>
        <div className="card text-white bg-dark" style={{ width: "18rem" }}>
          <img
            src=""
            className="card-img-top"
            alt="game picture"
            width="200px"
            height="250px"
          />
          <div className="card-body">
            <h5 className="card-title"> {ga.gameName} </h5>
            <p className="card-text">
Lorem ipsum dolor sit amet consectetur adipisicing elit. Odio, quam.
            </p>
          </div>
          <button className="btn btn-danger" onClick={() => deleteGame(ga.id)}> DELETE </button>
        </div>
      </div>
        
    )
})}</div>




        </div>
    )
}
