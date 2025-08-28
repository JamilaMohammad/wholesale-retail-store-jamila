import ProductList from './components/Product/ProductList'
import './App.css'
import Header from "./components/Header";
import { CartProvider } from "./components/Cart/Cart";
function App() {
  return (
    <>
        <CartProvider>
            <Header />
            <h1>Food Service Network</h1>
            <ProductList />
        </CartProvider>
    </>
  )
}

export default App
