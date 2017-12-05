import React, { Component } from "react";
import { Button, InputValidation } from "../components/common";
import CommonStyles from "../styles";
import * as actions from "../actions";
import { View, Text, TextInput, Image, StyleSheet } from "react-native";

export class SignInScreen extends Component {
  render() {
    return (
      <View>
        <Text>Sign In</Text>
        <Image
          style={styles.logo}
          resizeMode="contain"
          source={require("../../assets/logo.png")}
        />
        <TextInput name="email" type="email" label="Email" />

        <TextInput
          secureTextEntry={true}
          placeholder="Password"
          maxLength={20}
          style={[CommonStyles.input, styles.input]}
        />
        <Button
          title="sample"
          style={styles.button}
          onPress={this.handleLogin.bind(this)}
        />
      </View>
    );
  }
}
