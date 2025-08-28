import React from "react";
import AddToCart from "./Customer/Customer";

const Header = () => {
    return (
        <header className="bg-primary text-white py-3">
            <div className="container d-flex justify-content-between align-items-center">
                <AddToCart />
                <div className="nav-links d-flex gap-4">
                    <a href="/" className="text-white text-decoration-none">Home </a>
                    <a href="/products" className="text-white text-decoration-none">Products </a>
                    <a href="/cart" className="text-white text-decoration-none">Cart </a>
                    <a href="/about" className="text-white text-decoration-none">About </a>
                </div>

                {/* Optional button */}
                <button className="btn btn-light">Checkout</button>
            </div>
        </header>
    );
};

export default Header;
