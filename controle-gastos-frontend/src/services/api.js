import axios from 'axios';

const api = axios.create({
  baseURL: 'http://localhost:5227/api',
});

export default api;
