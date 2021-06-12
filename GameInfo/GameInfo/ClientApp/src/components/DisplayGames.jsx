import React from "react";
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import About from "./About";
import GameDetail from "./GameDetail";

export default function DisplayGames(props) {
  let displayGames = props.allGames.map((ga, i) => {
    return (
      <div className="col-md-3 mt-5" key={i}>
        <div className="card text-white bg-dark" style={{ width: "18rem" }}>
          <img
            src="https://cdn.europosters.eu/image/750/posters/call-of-duty-black-ops-cover-i8700.jpg"
            className="card-img-top"
            alt="game picture"
            width="200px"
            height="250px"
          />
          <div className="card-body">
            <h5 className="card-title"> {ga.gameName} </h5>
            <p className="card-text">
              {ga.rating} 
              <Link to={`/games/${ga.id}`}> details </Link>
              {/* <Link to={`/gamedetails`}> details </Link> */}

            </p>
          </div>
          <button
            className="btn btn-danger"
            onClick={() => props.deleteGame(ga.id)}
          >
            DELETE
          </button>
        </div>

      



      </div>
    );
  });

  return (
      <>
      
      <div className="row"> {displayGames} </div>
      

      </>
  );
}
