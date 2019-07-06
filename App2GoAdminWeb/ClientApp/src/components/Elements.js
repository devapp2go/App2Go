import React from "react";
import Element from "./Element"
import "./styles/Elements.css"

class Elements extends React.Component {
    render() {
      return (
        <div>
            <h3>Selecciona los elementos que quieras agregar a tu App.</h3>
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
            <input className="boton" type="submit" value="Siguiente" />
            </div>
        </div>
      );
    }
  }
  
  export default Elements;