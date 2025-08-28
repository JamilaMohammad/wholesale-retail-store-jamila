import React from 'react';

type ProductProps = {
    name: string
};

const Product: React.FC<ProductProps> = ({ name }) => {
    return (
        <div>
            <h1>{name}</h1>
        </div>
    );
};

export default Product;