import React, { Component } from 'react'
export default class StudentCard extends Component {



  handleData = (e) => {
    
    window.location.href='/students/'+this.props.info.id

}

  render() {
    return (
      
      <div className="card-container">
        <img src={this.props.info.img} alt=""/>
        <div className="desc">
          <h2>{this.props.info.name}</h2>
          <button  onClick={this.handleData} type="button">Show Courses</button>        
          <button onClick={()=>this.props.handle_Edit_Data(this.props.info)} > Edit</button> 
          <button onClick={()=>this.props.handle_Delete_Data(this.props.info.id)} > Delete</button>      
                          
        </div>
      </div>
      
    )
  }
}
