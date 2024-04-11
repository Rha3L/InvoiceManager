import ReactDOM from "react-dom/client";
import App from "./App";
import "./global.css";
import ThemeContextProvider from "./context/theme.context";

const root = ReactDOM.createRoot(
  document.getElementById("root") as HTMLElement
);
root.render(
  <ThemeContextProvider>
    <App />
  </ThemeContextProvider>
);
