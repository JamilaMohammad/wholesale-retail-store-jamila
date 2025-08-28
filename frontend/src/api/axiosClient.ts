import axios from "axios";

const axiosClient = axios.create({
    baseURL: "https://localhost:7258/", // Your backend URL
    headers: {
        "Content-Type": "application/json",
    },
});

// Optional: interceptors for auth tokens or logging
axiosClient.interceptors.request.use((config) => {
    // Add auth token if needed
    return config;
});

export default axiosClient;
