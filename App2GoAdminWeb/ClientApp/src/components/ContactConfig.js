import React, { Component } from "react";

export default class ContactConfig extends Component {
  render() {
    return (
      <div className="contenedor">
        <h2 className="etiqueta">Contacto</h2>
        <form>
          <input className="text-box" type="text" placeholder="Dirección" />
          <input className="text-box" type="text" placeholder="Telefono" />
          <input
            className="text-box"
            type="text"
            placeholder="Correo electrónico"
          />
          <input className="text-box" type="text" placeholder="Página web" />
        </form>
      </div>
    );
  }
}
