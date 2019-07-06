import React, { Component } from "react";
import { Row, Col } from "reactstrap";

export default class Single extends Component {
  render() {
    return (
      <div>
        <div>
          <Row className="contenedor">
            <Col xs="12">
              <p>{this.props.pname}</p>
              <p className="desc">{this.props.pdesc}</p>
            </Col>
          </Row>
          <Row>
            <Col xs="6">
              <p className="cost">{"$ " + this.props.pcost}</p>
            </Col>
            <Col xs="6">
              <button className="buy">Comprar!</button>
            </Col>
          </Row>
        </div>
      </div>
    );
  }
}
