import React, { useState, useEffect } from 'react'
import axios from 'axios'
import { useHistory } from 'react-router-dom'
import {
  Container,
  Button,
  Row,
  Col,
  Form,
  Spinner,
  Alert,
} from 'react-bootstrap'
import { useGoogleLogin } from 'react-google-login'

const clientId =
  '725272891211-e91a6v8fghhnccu9bck0utsnuui7ntmn.apps.googleusercontent.com'

export default function LoginScreen() {
  const url = 'https://pokewars.azurewebsites.net'
  const history = useHistory()
  const [email, setEmail] = useState(() => '')
  const [password, setPassword] = useState(() => '')
  const [name, setName] = useState(() => '')
  const [image, setImage] = useState(() => '')
  const [loginForm, setLoginForm] = useState(() => true)
  const [loading, setLoading] = useState(() => false)
  const [alert, setAlert] = useState(() => 'none')

  const onSuccess = (res) => {
    setLoading(true)
    localStorage.setItem('user', JSON.stringify(res.profileObj))
    setTimeout(() => {
      history.push('/')
      setLoading(false)
    }, 1000)
  }

  const onFailure = (res) => {
    console.log(res)
  }

  const { signIn } = useGoogleLogin({
    onSuccess,
    onFailure,
    clientId,
    isSignedIn: false,
    accessType: 'offline',
    // responseType: 'code',
    // prompt: 'consent',
  })

  const login = () => {
    setLoading(true)
    axios(`${url}/api/user`).then((res) => {
      if (res.status !== 200) {
        setTimeout(() => {
          setLoading(false)
          setAlert('block')
          return
        }, 1000)
      }

      res.data.forEach((user) => {
        if (user.email === email && user.password === password)
          localStorage.setItem('user', JSON.stringify(user))
      })

      if (JSON.parse(localStorage.getItem('user'))) {
        setTimeout(() => {
          history.push('/PokeWars')
          setLoading(false)
        }, 1000)
      } else {
        setTimeout(() => {
          setAlert('block')
          setLoading(false)
        }, 1000)

        setTimeout(() => {
          setAlert('none')
        }, 10000)
      }
    })
  }

  const signup = () => {
    setLoading(true)
    const user = {
      id: 0,
      email: email,
      password: password,
      name: name,
      image: image,
    }
    axios.post(`${url}/api/user`, user).then((res) => {
      if (res.status === 201)
        localStorage.setItem('user', JSON.stringify(res.data))
      setTimeout(() => {
        history.push('/PokeWars')
        setLoading(false)
      }, 1000)
    })
  }

  useEffect(() => {
    const user = JSON.parse(localStorage.getItem('user'))
    if (user) history.push('/PokeWars')
  }, [])

  return (
    <Container fluid>
      <Row className="pt-3">
        <Col />
        <Col lg="4" className="pt-5">
          {loading ? (
            <div className="text-center mt-5">
              <Spinner animation="grow" variant="primary" size="lg" />
            </div>
          ) : loginForm ? (
            <div>
              <h2 className="text-center text-light pb-3">
                Login to PokeWars™
              </h2>
              <Alert style={{ display: alert }} variant="danger">
                Something is not right{' '}
                <span role="img" aria-label="">
                  💩.
                </span>
              </Alert>
              <Form>
                <Form.Group>
                  <Form.Label className="text-light">Email</Form.Label>
                  <Form.Control
                    type="email"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                  />
                  <Form.Text className="text-info">reema@tuwaiq.edu</Form.Text>
                </Form.Group>

                <Form.Group>
                  <Form.Label className="text-light">Password</Form.Label>
                  <Form.Control
                    type="password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                  />
                  <Form.Text className="text-info">sipstea</Form.Text>
                </Form.Group>

                <Button
                  className="w-100 bg-accent mb-3"
                  onClick={() => login()}
                >
                  Login
                </Button>
                <Button
                  className="w-100 bg-google text-light mb-3"
                  onClick={() => signIn()}
                >
                  Login with Google
                </Button>

                <h5 className="text-center text-light">
                  Want to join the family?{' '}
                  <strong
                    className="text-accent"
                    onClick={() => setLoginForm(false)}
                  >
                    Signup here
                  </strong>
                  .
                </h5>
              </Form>
            </div>
          ) : (
            <div>
              <h2 className="text-center text-light">Signup for PokeWars™</h2>
              <Form>
                <Form.Group>
                  <Form.Label className="text-light">Email</Form.Label>
                  <Form.Control
                    type="email"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                  />
                </Form.Group>

                <Form.Group>
                  <Form.Label className="text-light">Name</Form.Label>
                  <Form.Control
                    type="text"
                    value={name}
                    onChange={(e) => setName(e.target.value)}
                  />
                </Form.Group>

                <Form.Group>
                  <Form.Label className="text-light">Image</Form.Label>
                  <Form.Control
                    type="text"
                    value={image}
                    onChange={(e) => setImage(e.target.value)}
                  />
                </Form.Group>

                <Form.Group>
                  <Form.Label className="text-light">Password</Form.Label>
                  <Form.Control
                    type="text"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                  />
                </Form.Group>

                <Button
                  className="w-100 bg-accent mb-3"
                  onClick={() => signup()}
                >
                  Signup
                </Button>
                <h5 className="text-center text-light">
                  Have an account?{' '}
                  <strong
                    className="text-accent"
                    onClick={() => setLoginForm(true)}
                  >
                    Login instead
                  </strong>
                  .
                </h5>
              </Form>
            </div>
          )}
        </Col>
        <Col />
      </Row>
    </Container>
  )
}
