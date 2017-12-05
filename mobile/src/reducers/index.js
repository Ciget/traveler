import { combineReducers } from "redux";
import { NavigationActions } from "react-navigation";

import { LOGIN, LOGOUT, ABOUT, MAIN } from "../actions/types";
import { AppNavigator } from "../screens/navigation";

const initialState = AppNavigator.router.getStateForAction(
  AppNavigator.router.getActionForPathAndParams("SignIn")
);

const navReducer = (state = initialState, action) => {
  let nextState;
  switch (action.type) {
    case ABOUT:
      nextState = AppNavigator.router.getStateForAction(
        NavigationActions.navigate({ routeName: "About" }),
        state
      );
      break;
    case MAIN:
      nextState = AppNavigator.router.getStateForAction(
        NavigationActions.reset({
          index: 0,
          actions: [NavigationActions.navigate({ routeName: "Main" })]
        }),
        state
      );
      break;
    default:
      nextState = AppNavigator.router.getStateForAction(action, state);
      break;
  }

  // Simply return the original `state` if `nextState` is null or undefined.
  return nextState || state;
};

const AppReducer = combineReducers({
  nav: navReducer
});

export default AppReducer;
