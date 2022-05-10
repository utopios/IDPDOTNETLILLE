import axios from "axios";

const url = "https://jsonplaceholder.typicode.com/posts";

export const getArticle = () => {
    return axios.get(url);
}
