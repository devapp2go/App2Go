import React from 'react';
import ReactDOM from 'react-dom';
import { connect } from 'react-redux';
import Greeting from "../components/Greeting.js"
import Instruction from "../components/Instruction.js"
import Order from "../components/Order.js"

class Orders extends React.Component {
    render() {
      return (
        <div>
          <Greeting/>,
          <Instruction/>,
          <Order/>
        </div>
      );
    }
  }

ReactDOM.render(
    <Orders/>,
    document.getElementById('root')
  );
  
  export default connect()(Orders);