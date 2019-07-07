import React from "react";
import "./styles/styles.css";
import NavBack from "../components/NavBack";
import InfoConfig from "../components/InfoConfig";
import ContactConfig from "../components/ContactConfig";
import ProductConfig from "../components/ProductConfig";
import PageConfigFinalizar from "../components/PageConfigFinalizar";

class PageConfig extends React.Component {
  render() {
    const productList = [1];
    const renderProducts = () => {
      return productList.map((item, index) =>{
        return(<ProductConfig/>);
      });
    }

    return (
      <div>
        <NavBack />
        <InfoConfig />
        <ContactConfig />
        {renderProducts()}
        <PageConfigFinalizar/>
      </div>
    );
  }
}

export default PageConfig;
