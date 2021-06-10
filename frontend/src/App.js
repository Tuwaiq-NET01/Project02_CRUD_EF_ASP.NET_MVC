import React from 'react'
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'
import HomeScreen from '../src/screens/HomeScreen'
import ArenaScreen from '../src/screens/ArenaScreen'
import LoginScreen from '../src/screens/LoginScreen'
import NotFoundScreen from '../src/screens/NotFoundScreen'
import NavBar from '../src/components/NavBar'

function App() {
  return (
    <div className="App">
      <Router>
        <NavBar />
        <Switch>
          <Route path="/PokeWars" component={() => <HomeScreen />} exact />
          <Route path="/arena" component={() => <ArenaScreen />} />
          <Route path="/login" component={() => <LoginScreen />} />
          <Route component={() => <NotFoundScreen />} />
        </Switch>
      </Router>
    </div>
  )
}

export default App
