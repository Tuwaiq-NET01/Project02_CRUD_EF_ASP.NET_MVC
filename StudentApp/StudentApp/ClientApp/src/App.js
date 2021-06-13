import React, { Component } from 'react';
import { Route } from 'react-router';
import  StudentForm  from './components/StudentForm';
import EditStudent from './components/EditStudent';
import Headers from './components/Headers'
import Students from './components/Students'
import StudentCourses from './components/StudentCourses'
import Question from './components/Question'
import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
      return (

             <div>
               <Headers/>
              <Route exact path='/' component={Students} />
              <Route path='/students/:id' component={StudentCourses} />
              <Route path='/courses/:id' component={Question} />
              <Route path='/addStudent' component={StudentForm} />
              <Route path='/EditStudent' component={EditStudent} />
              </div>
              
      
    );
  }
}
