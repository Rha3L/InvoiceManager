export interface ThemeContextInterface {
  darkMode: boolean;
  toggleDarkMode: () => void;
}

export interface ThemeContextProviderProps {
  children: React.ReactNode;
}
