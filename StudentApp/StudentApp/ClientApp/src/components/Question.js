import React, { Component } from 'react'
import axios from 'axios'
export default class Question extends Component {
    constructor(props) {
        super(props)
        this.state = {
            questions: [],
        }
    }
    componentDidMount(){
        axios({
            method: "get",
            url: "https://localhost:5001/Question/"+this.props.match.params.id
        }).then((response) => {
            this.setState({ questions: [...response.data] })
           
        }).catch((e) => {
            console.log("error", e);
        })
    }
    render() {
        return (
            <div>
                
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"/>

    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
                
                 {
                    this.state.questions.map((q,i)=>{
                      
                        return <div>

                    

                    <div class="row">
                            <div class="col s12 m6">
                            <div class="card blue-grey darken-1">
                                <div class="card-content white-text">
                                <span class="card-title">{q.question} </span>
                                <p>Question id:{q.id}.</p>
                                <p>Difficulty: {q.id}.</p>
                                </div>
                                <div class="card-action">
                                
                                <button onClick={()=>{alert(q.answer)}} >Show Answer </button>
                                </div>
                            </div>
                            </div>
                        </div>
                    
                        </div>
                        
                    })
                }
            </div>
        )
    }
}
