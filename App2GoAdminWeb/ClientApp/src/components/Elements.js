import React from "react";
import Element from "./Element"
import "./styles/Elements.css"
import { Link } from "react-router-dom";

class Elements extends React.Component {
    render() {
      return (
        <div>
            <h3 class="text-instruction">Selecciona los elementos que quieras agregar a tu App.</h3>
            <div class="element-column">
            <Element/>
            </div>
            <div class="element-column">
            <Element/>
            </div>
            <div class="element-column">
            <Element/>
            </div>
            <div class="element-column">
            <Element/>
            </div>
            <div class="element_submit" >
            <Link to="/pageconfig" className="boton">Siguiente</Link>
            </div>
        </div>
      );
    }
  }
  
  export default Elements;