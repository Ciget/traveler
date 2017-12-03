import React, {Component} from 'react';
import {Text, View, StyleSheet} from 'react-native';

export default class CityPreviewComponent extends Component
{
    constructor(props)
    {
        super();
    }

    render(){
        const { Name, Country } = this.props;
        return (<View style={styles.Container}>
                    <Text style={styles.Title}>{Name},{Country}</Text>
                    
                </View>);
    }
}


const styles = StyleSheet.create({
    Container: {
      backgroundColor: '#e7dbf9',
      paddingTop:10,

    },
    Title:{
        borderBottomWidth: 10,
        borderBottomColor: '#030205',
        backgroundColor: '#afffbd',
    }
  });
  