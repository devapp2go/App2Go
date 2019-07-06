import React from "react";
import Layout from "./components/Layout";
import Home from "./components/Home";
import Counter from "./components/Counter";
import FetchData from "./components/FetchData";
import Principal from "./pages/Principal";
import { BrowserRouter, Switch, Route } from "react-router-dom";

export default () => (
  <Layout>
    <
    <Route exact path="/" component={Principal} />
    <Route path="/counter" component={Counter} />
    <Route path="/fetch-data/:startDateIndex?" component={FetchData} />
  </Layout>
);
