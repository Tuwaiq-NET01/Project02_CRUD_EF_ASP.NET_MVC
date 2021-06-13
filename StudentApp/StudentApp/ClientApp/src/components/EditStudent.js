import React from "react";
import queryString from 'query-string'
import axios from 'axios'
export default class EditStudent extends React.Component {
    constructor(props) {
      super(props);
      let queries = queryString.parse(this.props.location.search)
      this.state = {
          Name: queries.name,
          Img: queries.img

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
        method: 'patch',
        url: 'https://localhost:5001/student?Id='+queryString.parse(this.props.location.search).id+'&Name='+this.state.Name+'&img='+this.state.Img
      }).then((res)=>{
        console.log("Yesss", res);
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

  