import React, { Component } from "react";
import Info from "../components/Info";
import Products from "../components/Products";
import Contact from "../components/Contact";
import NavMenu from "../components/NavMenu";
import "./css/styles.css";

export default class Principal extends Component {
  render() {
    return (
      <div>
        <NavMenu />
        <Info name="frutitas" info="lorem ipsum..." />
        <Products />
        <Contact />
      </div>
    );
  }
}
