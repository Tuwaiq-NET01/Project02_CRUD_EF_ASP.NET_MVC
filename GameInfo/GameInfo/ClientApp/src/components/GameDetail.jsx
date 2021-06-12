import React, { useState, useEffect } from "react";
import axios from 'axios';


export default function GameDetail(props) {
  const [game, setGame] = useState({});

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

  return (
    <div className="container">
      <h1>INFO ABOUT: {game.gameName}</h1>
    </div>
  );
}
