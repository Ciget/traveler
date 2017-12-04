import React, { Component } from "react";
import { View } from "react-native";

export class LoginScreen extends Component {
  render() {
    return (
      <View>
        <Image
          style={styles.logo}
          resizeMode="contain"
          source={require("../assets/login_logo.png")}
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
