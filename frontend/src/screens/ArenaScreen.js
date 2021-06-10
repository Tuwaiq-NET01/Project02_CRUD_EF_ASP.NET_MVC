import React, { useState, useEffect } from 'react'
import axios from 'axios'
import { Container, Table } from 'react-bootstrap'
import { useHistory } from 'react-router-dom'

const url = 'https://pokewars.azurewebsites.net'

export default function ArenaScreen() {
  const history = useHistory()
  const [battles, setBattles] = useState(() => [])

  useEffect(() => {
    axios(`${url}/api/arena`).then((res) => {
      if (res.status === 200) {
        setBattles(res.data)
      }
    })

    const user = JSON.parse(localStorage.getItem('user'))
    if (!user) history.push('/login')
  }, [])

  const deleteBattle = (id) => {
    axios.delete(`${url}/api/arena/${id}`).then((res) => {
      if (res.status === 204) {
        axios(`${url}/api/arena`).then((res) => {
          if (res.status === 200) {
            setBattles(res.data)
          }
        })
      }
    })
  }

  return (
    <Container fluid="md" className="mt-5 text-center">
      <h2 className="text-center text-light pb-3 mt-3">
        PokeWars™ <strong>Battles</strong>
      </h2>
      <Table striped bordered hover className="text-light">
        <thead>
          <tr>
            <th>Id</th>
            <th>Battle Date</th>
            <th>First Pokemon Id</th>
            <th>Second Pokemon Id</th>
            <th>Winner</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          {battles.map((battle, index) => {
            return (
              <tr key={index}>
                <td>{battle.id}</td>
                <td>{battle.date}</td>
                <td>{battle.firstPokemonId}</td>
                <td>{battle.secondPokemonId}</td>
                <td className="text-success">{battle.winnerId}</td>
                <td>
                  <button
                    className="btn bg-danger text-light"
                    onClick={() => deleteBattle(battle.id)}
                  >
                    Del
                  </button>
                </td>
              </tr>
            )
          })}
        </tbody>
      </Table>
    </Container>
  )
}
