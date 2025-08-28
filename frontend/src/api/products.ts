import axiosClient from "./axiosClient.ts";
import type {Product} from "../types/Product";
export const getProducts = async (): Promise<Product[]> => {
    const res = await axiosClient.get("/Product")
    return res.data;
}