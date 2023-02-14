import { API_ENDPOINT } from "./constant";

const { apiEndpoint } = API_ENDPOINT;

export const SAVE_STUDENT = `${apiEndpoint}/api/student/save`;

// DELETE API
export const DELETE_STUDENT_API_PATH = `${apiEndpoint}/api/student/id`;