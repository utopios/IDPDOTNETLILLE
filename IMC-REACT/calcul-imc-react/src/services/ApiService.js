import axios from "axios";

const url = "http://"+process.env.REACT_APP_API+":3001/";

export const get = path => {
  return axios.get(url + path);
};

export const post = (path, data) => {
  return axios.post(url + path, data);
};


