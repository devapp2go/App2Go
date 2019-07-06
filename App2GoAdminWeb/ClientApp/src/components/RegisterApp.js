import React from "react";
import "./styles/Register.css";

class Register extends React.Component {
  render() {
    return (
      <div className="contenedor">
        <form>
          <div>
            <h2 className="etiqueta">¡Registra tu App!</h2>
            <input type="text" placeholder="Nombre" />
            <br />
            <input placeholder="Selecciona tu logo" />
            <br />
          </div>
        </form>
      </div>
    );
  }
}

export default Register;
