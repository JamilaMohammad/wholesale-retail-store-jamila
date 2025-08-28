import React, {useEffect, useState} from "react";
import {getProducts} from "../../api/products";
import type {Product} from "../../types/Product";
//import {addToCart} from "../Cart/Cart";

var total = 0;
const handleClick = (productId: number, price: number) => {
    console.log("Product clicked:", productId);
    console.log("Product clicked:", price);
    total += price;
    console.log("Price", total)
};
const ProductList: React.FC = () => {
    const [products, setProducts] = useState<Product[]>([]);
    useEffect(() => {
        const fetchData = async () => {
            const data = await getProducts();
            setProducts(data);
        };
        fetchData();
    }, []);
    return (
        <div className="container">
            <div className="row">
                {products.map((p) => (
                    <div className="col-md-4 mb-4" key={p.id}>
                        <div className="card h-100">
                            <img
                                src={"https://images.unsplash.com/photo-1441861539200-6208cf4a122f?w=400&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTB8fGZvb2R8ZW58MHwyfDB8fHww"}
                                className="card-img-top"
                                alt={p.name}
                            />
                            <div className="card-body">
                                <h5 className="card-title">Product: {p.name}</h5>
                                <p className="card-text">Description: {p.description}</p>
                                <button
                                    className="btn btn-primary"
                                    onClick={() => handleClick(p.id, p.price)}
                                >
                                    Buy for R {p.price}
                                </button>
                            </div>
                        </div>
                    </div>
                ))}
            </div>
        </div>

    );
};
export default ProductList;