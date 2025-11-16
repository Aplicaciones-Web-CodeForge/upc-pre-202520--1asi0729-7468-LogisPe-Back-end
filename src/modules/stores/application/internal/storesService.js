import { findAll, findById, create, update, remove } from "../../infrastructure/persistence/memory/storesRepository.js";

export const listStores = () => findAll();
export const getStore = id => findById(id);
export const createStore = data => create(data);
export const updateStore = (id, data) => update(id, data);
export const removeStore = id => remove(id);