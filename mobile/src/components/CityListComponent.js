import React, { Component } from 'react';
import {View, FlatList, Text } from 'react-native';

import CityPreviewComponent from './CityPreviewComponent'

export default class CityListComponent extends Component
{
    constructor()
    {
        super();
        this.state = {
            cities: []
        };
    }

    componentWillMount(){
        this.setState({cities: [
            {id: 'Devin', city: 'Kyiv', country:'Ukraine'},
            {id: 'Jackson', city: 'Koln', country: 'Germany'},
            {id: 'James', city:'Barselona', country: 'Spain'},
            {id: 'Joel', city: 'Paris', country: 'France'},
            {id: 'John', city: 'Munich', country: 'Germany'},
            {id: 'Jillian', city: 'Munich', country: 'Germany'},
            {id: 'Jimmy', city: 'Stuttgard', country: 'Germany'},
            {id: 'Julie', city: 'Baden-Baden', country: 'Germany'},
          ]});
    }

    renderList(){
        return this.state.cities.map(city=><CityPreviewComponent key={city.id} Name={city.city} Country={city.country}/>);
    }
    render(){
        return (<View>
            {this.renderList()}
        </View>);
    }
}