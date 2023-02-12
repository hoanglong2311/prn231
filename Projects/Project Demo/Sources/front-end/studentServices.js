// import { API_ENDPOINT } from "./constant";

// const { apiEndpoint } = API_ENDPOINT;

// export const SAVE_STUDENT = `${apiEndpoint}/api/student/save`;

const END_POINTS = {
  GET_ALL: "/api/student/list",
  GET_ONE: "/students/:id",
  CREATE: "/api/student/save",
  UPDATE: "/api/student/Update",
  DELETE: "/api/student/id",
};

window.GetAllStudentsApi = () => {
  return axios.get(`https://localhost:7190${END_POINTS.GET_ALL}`);
};
