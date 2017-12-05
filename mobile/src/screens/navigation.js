import { connect } from "react-redux";
import { StackNavigator, addNavigationHelpers } from "react-navigation";
import SignIn from "./signIn";
import SignUp from "./signUp";

export const AppNavigator = StackNavigator({
  SignUp: {
    screen: SignUp
  },
  SignIn: {
    screen: SignIn
  }
});

const AppWithNavigationState = ({ dispatch, nav }) => (
  <AppNavigator
    navigation={addNavigationHelpers({
      dispatch,
      state: nav
    })}
  />
);

const mapStateToProps = state => ({
  nav: state.nav
});

export default connect(mapStateToProps)(AppWithNavigationState);
