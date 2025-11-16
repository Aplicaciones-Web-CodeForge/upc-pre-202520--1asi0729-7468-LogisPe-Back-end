import { findAll, findById, create, update, remove } from "../../infrastructure/persistence/memory/ordersRepository.js";

export const listOrders = () => findAll();
export const getOrder = id => findById(id);
export const createOrder = data => create(data);
export const updateOrder = (id, data) => update(id, data);
export const removeOrder = id => remove(id);