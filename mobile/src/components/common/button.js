import React, { Component } from "react";
import CommonStyles from "../../styles";
import { TouchableOpacity, Text, StyleSheet, View } from "react-native";

export class Button extends Component {
  render() {
    let { title, style, onPress } = this.props;
    return (
      <View style={[CommonStyles.button, styles.container, style]}>
        <TouchableOpacity onPress={onPress}>
          <Text style={CommonStyles.buttonText}>{title}</Text>
        </TouchableOpacity>
      </View>
    );
  }
}
const styles = StyleSheet.create({
  container: {}
});
