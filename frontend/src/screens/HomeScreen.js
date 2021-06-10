import React, { useState, useEffect } from 'react'
import axios from 'axios'
import { useHistory } from 'react-router-dom'
import {
  Container,
  Card,
  Button,
  Row,
  Col,
  Form,
  Alert,
  Spinner,
} from 'react-bootstrap'
import { Link } from 'react-router-dom'

export default function HomeScreen() {
  const url = 'https://pokewars.azurewebsites.net'
  const history = useHistory()
  const [user, setUser] = useState({
    id: 0,
    name: '',
    image: '',
    email: '',
    password: '',
  })
  const [pokemons, setPokemons] = useState(() => [])
  const [name, setName] = useState(() => '')
  const [email, setEmail] = useState(() => '')
  const [password, setPassword] = useState(() => '')
  const [image, setImage] = useState(() => '')
  const [alert, setAlert] = useState(() => 'none')
  const [loadingUpdate, setLoadingUpdate] = useState(() => false)
  const [loadingDelete, setLoadingDelete] = useState(() => false)
  const [addPokemon, setAddPokemon] = useState(() => false)
  const [pokeName, setPokeName] = useState(() => '')
  const [pokeFAbility, setPokeFAbility] = useState(() => '')
  const [pokeSAbility, setPokeSAbility] = useState(() => '')
  const [pokeDesc, setPokeDesc] = useState(() => '')
  const [pokeGif, setPokeGif] = useState(() => '')
  const [pokeRank, setPokeRank] = useState(() => '')

  const updateUser = () => {
    setLoadingUpdate(true)
    const updatedUser = {
      id: user.id,
      name: name,
      email: email,
      password: password,
      image: image,
    }
    axios.put(`${url}/api/user/${user.id}`, user).then((res) => {
      if (res.status === 204) {
        localStorage.setItem('user', JSON.stringify(updatedUser))
        setUser(updatedUser)
        setName(updatedUser.name)
        setEmail(updatedUser.email)
        setPassword(updatedUser.password)
        setImage(updatedUser.image)
        setAlert('block')
        setTimeout(() => {
          setAlert('none')
        }, 5000)
        setTimeout(() => setLoadingUpdate(false), 1000)
      }
    })
  }

  const deletePokemon = (id) => {
    setLoadingDelete(true)
    setAddPokemon(false)
    axios.delete(`${url}/api/pokemon/${id}`).then((res) => {
      if (res.status === 204) {
        axios(`${url}/api/pokemon`).then((res) => {
          setPokemons(res.data)
          setTimeout(() => setLoadingDelete(false), 1000)
        })
      }
    })
  }

  const createPokemon = () => {
    setLoadingDelete(true)
    const pokemon = {
      id: 0,
      name: pokeName,
      description: pokeDesc,
      firstAbility: pokeFAbility,
      secondAbility: pokeSAbility,
      gifImage: pokeGif,
      rankId: pokeRank,
    }
    axios.post(`${url}/api/pokemon`, pokemon).then((res) => {
      if (res.status === 201) {
        axios(`${url}/api/pokemon`).then((res) => {
          setPokemons(res.data)
        })
      }
      setTimeout(() => setLoadingDelete(false), 1000)
    })
  }

  useEffect(() => {
    const user = JSON.parse(localStorage.getItem('user'))
    if (user) {
      setUser(user)
      setName(user.name)
      setEmail(user.email)
      setPassword(user.password)
      setImage(user.image)
    } else {
      history.push('/login')
    }

    axios(`${url}/api/pokemon`).then((res) => {
      setPokemons(res.data)
    })
  }, [])

  return (
    <Container fluid>
      <Row>
        <Col lg="6" className=" text-center">
          <h2 className="text-center text-light pb-3 mt-3">
            PokeTrainer™: <strong>{user.name}</strong>
          </h2>
          <Link to="/arena">
            <img src={image} alt="user" />
          </Link>
          {loadingUpdate ? (
            <div className="text-center mt-5">
              <Spinner animation="grow" variant="primary" size="lg" />
            </div>
          ) : (
            <div>
              <Alert style={{ display: alert }} variant="success">
                Updates saved to SQL Server Database{' '}
                <span role="img" aria-label="">
                  👍
                </span>
                .
              </Alert>
              <Form>
                <Form.Group>
                  <Form.Control
                    type="text"
                    value={name}
                    onChange={(e) => setName(e.target.value)}
                  />
                </Form.Group>

                <Form.Group>
                  <Form.Control
                    type="text"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                  />
                </Form.Group>

                <Form.Group>
                  <Form.Control
                    type="password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                  />
                </Form.Group>

                <Form.Group>
                  <Form.Control
                    type="text"
                    value={user.image}
                    onChange={(e) => setImage(e.target.value)}
                  />
                </Form.Group>

                <Button
                  className="w-100 bg-accent mb-3"
                  onClick={() => updateUser()}
                >
                  Update
                </Button>
              </Form>
            </div>
          )}
        </Col>
        <Col lg="6" align="center">
          <h2 className="text-center text-light pb-3 mt-3">
            Your PokeWars™ <strong>Inventory</strong>
          </h2>
          <div className="scrollable">
            {loadingDelete ? (
              <div className="text-center mt-5">
                <Spinner animation="grow" variant="primary" size="lg" />
              </div>
            ) : (
              <div>
                {pokemons.map((pokemon, index) => {
                  return (
                    <Card
                      key={index}
                      className="mt-3 mb-5"
                      style={{
                        width: '18rem',
                      }}
                    >
                      <Card.Img variant="top" src={pokemon.gifImage} />
                      <Card.Body>
                        <Card.Title>{pokemon.name}</Card.Title>
                        <Card.Text>{pokemon.description}</Card.Text>
                        <Button
                          className="w-100 bg-accent"
                          variant="primary"
                          onClick={() => deletePokemon(pokemon.id)}
                        >
                          Sell {pokemon.name}
                        </Button>
                      </Card.Body>
                    </Card>
                  )
                })}
                {addPokemon ? (
                  <Card
                    className="mt-3 mb-5 bg-accent"
                    style={{
                      width: '18rem',
                    }}
                  >
                    <Card.Body>
                      <Form>
                        <Form.Group>
                          <Form.Control
                            type="text"
                            value={pokeName}
                            placeholder="Name"
                            onChange={(e) => setPokeName(e.target.value)}
                          />
                        </Form.Group>

                        <Form.Group>
                          <Form.Control
                            type="text"
                            value={pokeDesc}
                            placeholder="Description"
                            onChange={(e) => setPokeDesc(e.target.value)}
                          />
                        </Form.Group>

                        <Form.Group>
                          <Form.Control
                            type="text"
                            value={pokeFAbility}
                            placeholder="First Ability"
                            onChange={(e) => setPokeFAbility(e.target.value)}
                          />
                        </Form.Group>

                        <Form.Group>
                          <Form.Control
                            type="text"
                            value={pokeSAbility}
                            placeholder="Second Ability"
                            onChange={(e) => setPokeSAbility(e.target.value)}
                          />
                        </Form.Group>

                        <Form.Group>
                          <Form.Control
                            type="text"
                            value={pokeGif}
                            placeholder="Gif Url"
                            onChange={(e) => setPokeGif(e.target.value)}
                          />
                        </Form.Group>

                        <Form.Group>
                          <Form.Control
                            type="text"
                            value={pokeRank}
                            placeholder="Rank Id"
                            onChange={(e) => setPokeRank(e.target.value)}
                          />
                        </Form.Group>

                        <Button
                          className="w-100  bg-light text-accent mb-3"
                          onClick={() => createPokemon()}
                        >
                          Add
                        </Button>
                      </Form>
                    </Card.Body>
                  </Card>
                ) : (
                  <Card
                    className="mt-3 mb-5 bg-accent"
                    style={{
                      width: '18rem',
                    }}
                  >
                    <Card.Body>
                      <Card.Title className="text-light">
                        Expand Your Inventory
                      </Card.Title>
                      <Card.Text className="text-light">
                        Pokemons are a db insertion away.
                      </Card.Text>
                      <Button
                        className="w-100 bg-light text-accent"
                        variant="primary"
                        onClick={() => setAddPokemon(true)}
                      >
                        Acquire a Pokemon
                      </Button>
                    </Card.Body>
                  </Card>
                )}
              </div>
            )}
          </div>
        </Col>
      </Row>
    </Container>
  )
}
