import config from './../configs/';
import React, { Component } from 'react';
import ReactTable from "react-table";
import 'react-table/react-table.css'
import axios from 'axios';
import Moment from 'moment'

export  class User extends Component {
  state = {
    users: []
  }

  componentDidMount() {
    axios.get(`${config.BASE_URL}/api/users/v1/all`)
      .then(res => {
        const users = res.data;
        this.setState({ users });
        console.log(users)
      })
     
  }
  render()
   {
    const columns = [{
        Header: 'Name',// format
        accessor: 'name' //field mapping
    }, {
        Header: 'UserName',
        accessor: 'userName',
    }, {
        Header: 'CreateDay',
        accessor: 'createDay',
          Cell: props => <span className='number'>{Moment(props.value)
            .local()
            .format("DD-MM-YYYY hh:mm:ss a")}</span> // Custom cell components!
    }];
    return (
      <div>
          <h2>List uses</h2>
                
                <ReactTable data={this.state.users} columns={columns}
                    defaultPageSize={10} />
      </div>
    )
  }
}