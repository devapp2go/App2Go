import React from "react";
import "./styles/Register.css";

class Register extends React.Component {
  render() {
    return (
      <div className="contenedor">
        <form>
          <div>
            <h2 className="etiqueta">Registrate añadiendo tus datos</h2>
            <input className="text-box" type="text" placeholder="Nombre" />
            <br />
            <input className="text-box" type="text" placeholder="Apellido" />
            <br />
            <input
              className="text-box"
              type="text"
              placeholder="Numero de telefono"
            />
            <br />
            <input
              className="text-box"
              type="email"
              placeholder="Correo Electrónico"
            />
            <br />
            <input type="checkbox" />
            <span className="etiqueta">
              He leído y acepto la{" "}
              <a href="www.google.com">Polìtica de Privacidad</a>
            </span>
            <br />
            <input className="boton" type="submit" value="Siguiente" />
          </div>
        </form>
      </div>
    );
  }
}

export default Register;
