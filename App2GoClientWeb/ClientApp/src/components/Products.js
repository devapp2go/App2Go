import React, { Component } from "react";
import { Row, Col } from "reactstrap";
import Single from "../components/Single";

export default class Products extends Component {
  render() {
    return (
      <div>
        <p>Products</p>
        <Row>
          <Col xs="6">
            <Single
              pname="Producto 1"
              pdesc="Descripción del primer producto XD"
              pcost="40"
            />
          </Col>
          <Col xs="6">
            <Single
              pname="producto 2"
              pdesc="DEscripcion del segundo producto lorem ipsum..."
              pcost="30"
            />
          </Col>
        </Row>
        <Row>
          <Col xs="6">
            <Single
              pname="Producto 3"
              pdesc="Descripción del segundo producto XD"
              pcost="40"
            />
          </Col>
          <Col xs="6">
            <Single
              pname="producto 4"
              pdesc="DEscripcion del cuarto producto lorem ipsum..."
              pcost="30"
            />
          </Col>
        </Row>
      </div>
    );
  }
}
