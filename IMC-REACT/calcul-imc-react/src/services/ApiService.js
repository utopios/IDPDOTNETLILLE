import axios from "axios";

const url = "http://"+process.env.REACT_APP_API+":3001/";
//docker run -d -p 80:80 -e REACT_APP_API=172.17.0.2 react-with-stages
export const get = path => {
  return axios.get(url + path);
};

export const post = (path, data) => {
  return axios.post(url + path, data);
};


