import { findAll, findById, create, update, remove } from "../../infrastructure/persistence/memory/stocksRepository.js";

export const listStocks = () => findAll();
export const getStock = id => findById(id);
export const createStock = data => create(data);
export const updateStock = (id, data) => update(id, data);
export const removeStock = id => remove(id);