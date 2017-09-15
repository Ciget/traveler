import React from 'react';
import { StyleSheet, ScrollView } from 'react-native';

import CityListComponent from './src/components/CityListComponent';

export default class App extends React.Component {
  render() {
      return (<ScrollView style={styles.container}>
        <CityListComponent/>
        </ScrollView>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    backgroundColor: '#fff',
    marginTop:30,
    marginLeft:5,
    marginRight:5
  },
});
