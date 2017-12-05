import React from "react";
import { StyleSheet, Text, View } from "react-native";
import { Provider } from "react-redux";
import { createStore } from "redux";
import * as reducers from "./src/reducers/";

export default class App extends React.Component {
  render() {
    return (
      <Provider store={createStore(reducers)}>
        <AppWithNavigationState />
      </Provider>
    );
  }
}
