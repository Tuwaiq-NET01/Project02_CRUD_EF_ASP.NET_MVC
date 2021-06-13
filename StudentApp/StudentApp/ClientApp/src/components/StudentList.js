import React, { Component } from 'react'
import StudentCard from './StudentCard'
export default class StudentList extends Component {
    render() {
        return (
            <div className="list">
                {
                    this.props.books.map((book,i)=>{
                      
                        return <StudentCard key={i} info={book} handle_Delete_Data={this.props.handle_Delete_Data} handle_Edit_Data={this.props.handle_Edit_Data}/>
                    })
                }
                

               
            </div>
        )
    }
}
