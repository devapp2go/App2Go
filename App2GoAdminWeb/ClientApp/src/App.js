import React from "react";
import Layout from "./components/Layout";
import Login from "./components/Login";
import PageRegister from "./pages/PageRegister";
import { BrowserRouter, Switch, Route } from "react-router-dom";

export default () => (
  <Layout>
    <BrowserRouter>
      <Switch>
        <Route exact path="/" component={Login} />
        <Route exact path="/pageregister" component={PageRegister} />
      </Switch>
    </BrowserRouter>
  </Layout>
);
