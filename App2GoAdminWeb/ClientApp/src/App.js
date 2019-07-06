import React from "react";
import Layout from "./components/Layout";
import Login from "./components/Login";
import PageRegister from "./pages/PageRegister";
import PageConfig from "./pages/PageConfig";
import { BrowserRouter, Switch, Route } from "react-router-dom";

export default () => (
  <Layout>
    <BrowserRouter>
      <Switch>
        <Route exact path="/" component={Login} />
        <Route exact path="/pageregister" component={PageRegister} />
        <Route exact path="/pageconfig" component={PageConfig} />
      </Switch>
    </BrowserRouter>
  </Layout>
);
