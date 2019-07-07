import React from "react";
import ReactDOM from "react-dom";
import { connect } from "react-redux";
import "./login.css";
import { Input, Button } from "reactstrap";
import { Link } from "react-router-dom";

class Greeting extends React.Component {
  render() {
    return (
      <div class="greeting">
        <p>¡Hola! Bienvenido a</p>
        <img
          class="logo"
          src={process.env.PUBLIC_URL + "/media/img/LOGO.png"}
        />
      </div>
    );
  }
}

class Oauth extends React.Component {
  render() {
    return (
      <div>
        <p>Inicia sesión con</p>
        <div class="oauth-fb" />
        <br />
        <div class="oauth-google" />
        <p>o</p>
      </div>
    );
  }
}

class LoginData extends React.Component {
  render() {
    return (
      <div>
        <input class="input-login" placeholder="Correo electrónico" />
        <br />
        <input class="input-login" placeholder="Contraseña" type="password" />
        <small>¿Olvidaste tu contraseña? </small>
        <a class="a-login" href="#">
          Haz click aquí
        </a>
        <div class="div-button">
        <Link to="/pageconfig" className="boton" >INICIAR SESIÓN
          </Link>
        </div>
        <hr class="hrlogin" />
      </div>
    );
  }
}

class Register extends React.Component {
  render() {
    return (
      <div>
        <small>¿Aún no tienes una App?</small>
        <div class="div-button">
        <Link to="/pageregister" className="boton" >¡CREA TU APP!
          </Link>
        </div>
      </div>
    );
  }
}

class Login extends React.Component {
  render() {
    return (
      <div class="text">
        <Greeting />
        <Oauth />
        <LoginData />
        <Register />
      </div>
    );
  }
}

//ReactDOM.render(<Login />, document.getElementById("root"));
export default Login;
