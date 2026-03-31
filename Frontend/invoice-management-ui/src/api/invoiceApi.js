import axiosClient from "./axiosClient";

export async function getAllInvoices() {
  const response = await axiosClient.get("/invoices");
  return response.data;
}

export async function getInvoiceById(id) {
  const response = await axiosClient.get(`/invoices/${id}`);
  return response.data;
}

export async function createInvoice(payload) {
  const response = await axiosClient.post("/invoices", payload);
  return response.data;
}