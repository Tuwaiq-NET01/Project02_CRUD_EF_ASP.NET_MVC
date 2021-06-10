import React from 'react'
import { Navbar, Nav } from 'react-bootstrap'
import { Link } from 'react-router-dom'

export default function NavBar() {
  return (
    <Navbar bg="dark" variant="dark">
      <Navbar.Brand>
        <Link to="/PokeWars">
          <img
            alt=""
            src="https://aux3.iconspalace.com/uploads/645019229296460368.png"
            width="30"
            height="30"
            className="d-inline-block align-top"
          />{' '}
          PokeWars™
        </Link>
      </Navbar.Brand>
      <Nav className="mr-auto">
        <Nav.Link as={Link} to="/PokeWars">
          Home
        </Nav.Link>
        <Nav.Link as={Link} to="/arena">
          Arena
        </Nav.Link>
        <Nav.Link
          href="https://pokewars.azurewebsites.net/swagger/index.html"
          target="_blank"
        >
          Swagger UI
        </Nav.Link>
        <Nav.Link
          as={Link}
          to="/login"
          onClick={() => {
            localStorage.setItem('user', null)
          }}
        >
          Logout
        </Nav.Link>
      </Nav>
    </Navbar>
  )
}
