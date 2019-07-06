import React, { Component } from "react";

export default class InfoConfig extends Component {
  render() {
    return (
      <div className="contenedor">
        <p className="etiqueta">Información</p>
        <textarea
          placeholder="Agrega tu texto aquí"
          className="text-box text-area"
        />
      </div>
    );
  }
}
