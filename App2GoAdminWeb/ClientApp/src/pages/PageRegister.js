import React from "react";
import NavBack from "../components/NavBack";
import SocialRegister from "../components/SocialRegister";
import Register from "../components/Register";
import "./styles/styles.css";

class PageRegister extends React.Component {
  render() {
    return (
      <div>
        <NavBack />
        <SocialRegister />
        <Register />
      </div>
    );
  }
}

export default PageRegister;
