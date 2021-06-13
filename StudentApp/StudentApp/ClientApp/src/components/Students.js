import React, { Component } from 'react'
import StudentList from './StudentList'
import axios from 'axios'
export default class Students extends Component {
    constructor(props) {
        super(props)
        this.state = {
            books: [],
            searchFiled: ''
        }
    }
    componentDidMount() {
        axios({
            method: "get",
            url: "https://localhost:5001/Student"
        }).then((response) => {
            this.setState({ books: [...response.data] })
            console.log("res", [...response.data]);
        }).catch((e) => {
            console.log("error", e);
        })
    }

    handleSearch = (e) => {
        console.log(e.target.value);
        this.setState({
            searchFiled: e.target.value
        })
    }
    handle_Delete_Data = (id) => {

        axios({
            method: "delete",
            url: "https://localhost:5001/Student/" + id
        }).then((response) => {
            var array = [... this.state.books];
            var index
            for (let i = 0; i < array.length; i++) {
                if (array[i].id == id)
                    index = i

            } // make a separate copy of the array
            console.log(index, "xrex", array);
            if (index != -1) {
                console.log(">>> ", id)
                array.splice(index, 1);
                this.setState({ books: array });
            }



        }).catch((e) => {
            console.log("error", e);
        })
    }
    handle_Edit_Data = (info) => {
        console.log("Name", info.name);
        window.location.href = '/EditStudent?id=' + info.id + "&name=" + info.name + "&img=" + info.img
    }
    render() {

        return (
            <div className="wrapper">
                <StudentList handle_Delete_Data={this.handle_Delete_Data} books={this.state.books} handle_Edit_Data={this.handle_Edit_Data} />

                <div onClick={() => { window.location.href = '/addStudent' }} className="card-container">
                    <img src='data:image/png;base64,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' alt="" />
                </div>

            </div>
        )
    }
}
