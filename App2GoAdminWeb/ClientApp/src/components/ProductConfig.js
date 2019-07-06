import React, { Component } from "react";

export default class ProductConfig extends Component {
  render() {
    return (
      <div>
        <div className="contenedor">
          <h2 className="etiqueta">Productos</h2>
          <form>
            <input className="text-box" type="text" placeholder="Producto" />
            <input className="text-box" type="text" placeholder="Descripción" />
            <div className="media">
              <input
                className="text-box numbers"
                type="number"
                placeholder="Cantidad"
              />
            </div>
            <div className="media">
              <input
                className="text-box numbers"
                type="number"
                placeholder="Costo"
              />
            </div>
          </form>
        </div>
        <div>
          <button className="boton">Finalizar</button>
        </div>
      </div>
    );
  }
}
