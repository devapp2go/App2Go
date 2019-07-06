import React from "react";
import "./styles/SocialRegister.css";

class SocialRegister extends React.Component {
  render() {
    return (
      <div className="contenedor">
        <h2 className="etiqueta">Registrate añadiendo tus datos</h2>
        <div className="media">
          <button className="facebook"> Facebook </button>
        </div>
        <div className="media">
          <button className="google"> Google </button>
        </div>
      </div>
    );
  }
}

export default SocialRegister;
