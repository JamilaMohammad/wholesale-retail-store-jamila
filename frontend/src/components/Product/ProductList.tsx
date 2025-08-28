import React, {useEffect, useState} from "react";
import {getProducts} from "../../api/products";
import type {Product} from "../../types/Product";

const ProductList: React.FC = () => {
    console.log("!!!!!!!!!!!");
    const [products, setProducts] = useState<Product[]>([]);
    useEffect(() => {
        const fetchData = async () => {
            const data = await getProducts();
            setProducts(data);
        };
        fetchData();
    }, []);
    return (<div>
        {products.map((p) => (
            <div key={p.id}>{p.name}{p.description}</div>
        ))}
    </div>);
};
export default ProductList;