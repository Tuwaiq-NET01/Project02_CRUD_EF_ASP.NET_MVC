import React, { useState, useEffect } from "react";
import axios from 'axios';
import GameForm from "./GameForm";


export default function GameDetail(props) {
  const [game, setGame] = useState({});

  const [gameName, setGameName] = useState('');
  const [gameImage, setGameImage] = useState('');
  const [gameDesc, setGameDesc] = useState('');


  const [editMode, setEditMode] = useState(false)

  const editStatus = () => {
      setEditMode(!editMode)
  }


  useEffect(() => {
    axios
      .get(`https://localhost:44384/api/games/${props.match.params.id}`)
      .then((res) => {
        console.log(res);
        setGame(res.data)
      })
      .catch((err) => {
        console.error(err);
      });
  }, []);




  const editGame = (game) => {
      console.log('EDIT SECTION: ', game);

      axios.put(`https://localhost:44384/api/games/${props.match.params.id}`, game)
.then(res => {
  console.log(res)
})
.catch(err => {
  console.error(err); 
})

  }

  return (
    <div className="container mt-3">

      

      <div class="row">
    <div class="col-lg-4">
        <img src={game.image} alt="game image" width="350px" />
    </div>
    <div class="col-8">

        <br />
    
    {editMode ? 
    <div> 

<GameForm game={game} editGame={editGame} mode="edit" editStatus={editStatus}/>
    
    
{/* <div className="d-flex justify-content-end">

<button className="btn btn-primary me-2" onClick={editGame}>
    UPDATE!
</button>
<button className="btn btn-danger" onClick={() => setEditMode(false)}> CANCEL </button>
</div> */}


    
    

    </div>
    
    : 
    
    
    <div>   <h1>{game.gameName}</h1>
    <br />

    <p>{game.description}</p>
    

    

    <div className="d-flex justify-content-end">

<button className="btn btn-secondary me-2" onClick={props.history.goBack}>
    GO BACK
</button>
<button className="btn btn-warning" onClick={editStatus}>
    EDIT
</button>
</div>


    </div> }

      

        
    </div>
</div>





    </div>
  );
}
