import React from "react";
import NavBack from "../components/NavBack";
import Elements from "../components/Elements";
import RegisterApp from "../components/RegisterApp";
import "./styles/styles.css";

class PageRegisterTwo extends React.Component {
  render() {
    return (
      <div class="background">
        <NavBack />
        <RegisterApp />
        <Elements/>
      </div>
    );
  }
}

export default PageRegisterTwo;
