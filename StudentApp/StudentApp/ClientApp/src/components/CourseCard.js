import React, { Component } from 'react'

export default class CourseCard extends Component {

    handleData = (e) => {
    
        window.location.href='/courses/'+this.props.info.id
    
    }
      render() {
        return (
          
            <div className="card-container">
            <img src={this.props.info.img} alt=""/>
            <div className="desc">
              <h2>{this.props.info.name}</h2>
              <button  onClick={this.handleData} type="button">Show More</button>                    
            </div>
          </div>
          
        )
      }
    }
    