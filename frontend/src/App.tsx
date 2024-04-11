import { useContext } from "react";
import { ThemeContext } from "./context/theme.context";

const App = () => {
  const { darkMode } = useContext(ThemeContext);
  const appStyle = darkMode ? "dark-mode app" : "app";

  return <div className={appStyle}>App</div>;
};

export default App;
