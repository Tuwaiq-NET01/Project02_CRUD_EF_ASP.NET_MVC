import React, {useState, useEffect} from 'react'
import {BsFillStarFill} from 'react-icons/bs';


export default function GameForm(props) {

    const [gameName, setGameName] = useState('');
    const [gameImage, setGameImage] = useState('');
    const [gameDesc, setGameDesc] = useState('');
    const [rating, setRating] = useState(1);

    const editGame = () => {
        let game = {
            gameName : gameName,
            image : gameImage,
            description: gameDesc,
            rating: rating
        }

        props.editGame(game)
    }
    

    useEffect(() => {
        setGameName(props.game.gameName)
        setGameImage(props.game.image)
        setGameDesc(props.game.description)
    }, [])

    return (
        <div>

            
      <form>


<div class="mb-3">
<label for="gameName" class="form-label">Game Name: </label>
<input type="text" class="form-control" id="gameName" value={gameName} onChange={(e) => setGameName(e.target.value)} />
</div>
<div class="mb-3">
<label for="gameImage" class="form-label">Game Image: </label>
<input type="text" class="form-control" id="gameImage" value={gameImage} onChange={(e) => setGameImage(e.target.value)} />
</div>
<div class="mb-3">
<label for="gameDesc" class="form-label">Description: </label>
<textarea class="form-control" id="gameDesc" rows="3" value={gameDesc} onChange={(e) => setGameDesc(e.target.value)}></textarea>
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

    
<div className="d-flex justify-content-end">

<button type='submit' className="btn btn-primary me-2" onClick={editGame}>
    UPDATE!
</button>
{/* <button className="btn btn-danger" onClick={() => setEditMode(false)}> CANCEL </button> */}
</div>


        </div>
    )
}
