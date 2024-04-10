import { createContext, useState } from "react";
import { ThemeContextInterface, ThemeContextProviderProps } from "../types";

export const ThemeContext = createContext<ThemeContextInterface>({
  darkMode: false,
  toggleDarkMode: () => {},
});

const ThemeContextProvider = ({ children }: ThemeContextProviderProps) => {
  const [darkMode, setDarkMode] = useState<boolean>(false);

  const toggleDarkMode: () => void = () => {
    setDarkMode((prevState) => !prevState);
  };

  return (
    <ThemeContext.Provider value={{ darkMode, toggleDarkMode }}>
      {children}
    </ThemeContext.Provider>
  );
};

export default ThemeContextProvider;
