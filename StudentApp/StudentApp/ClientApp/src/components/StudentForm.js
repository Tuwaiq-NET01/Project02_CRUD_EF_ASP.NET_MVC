import React from 'react';
import axios from 'axios'
export default class StudentForm extends React.Component {
    constructor(props) {
      super(props);
      this.state = {
          Name: " ",
          Img: ''

        };
  
      this.handleNameChange = this.handleNameChange.bind(this);
      this.handleImgChange = this.handleImgChange.bind(this);
      this.handleSubmit = this.handleSubmit.bind(this);

      
    }
  
    handleNameChange(event) {
       
      this.setState({Name: event.target.value});
      console.log(this.state.Name);
    }

    handleImgChange(event) {
        this.setState({Img: event.target.value});
      }
  
    handleSubmit(e) {
      axios({
        method: 'post',
        url: 'https://localhost:5001/student?Name='+this.state.Name+'&img='+this.state.Img
      }).then((res)=>{
        console.log("res", res);
        window.location.href='/'
      });
    }
  
    render() {
      return (
       <div>
          <label>
            Name:
            <input type="text" value={this.state.Name} onChange={(e)=>this.handleNameChange(e)} />
          </label>
          <br/>
          <label>
            Img:
            <input type="text" value={this.state.Img} onChange={this.handleImgChange} />
          </label>
          <br/>
          <input onClick={(e)=>this.handleSubmit(e)} type="submit" value="Submit" />
        </div>
      );
    }
  }

  