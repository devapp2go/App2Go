import React from "react";
import "./styles/styles.css";
import NavBack from "../components/NavBack";
import InfoConfig from "../components/InfoConfig";
import ContactConfig from "../components/ContactConfig";
import ProductConfig from "../components/ProductConfig";

class PageConfig extends React.Component {
  render() {
    return (
      <div>
        <NavBack />
        <InfoConfig />
        <ContactConfig />
        <ProductConfig />
      </div>
    );
  }
}

export default PageConfig;
