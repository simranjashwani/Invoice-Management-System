import axiosClient from "./axiosClient";

export async function loginUser(payload) {
  const response = await axiosClient.post("/auth/login", payload);
  return response.data;
}