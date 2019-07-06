import React, { Component } from "react";

export default class Info extends Component {
  render() {
    return (
      <div>
        <div>
          <h1 className="">{this.props.name}</h1>
          <p>{this.props.info}</p>
        </div>
      </div>
    );
  }
}
