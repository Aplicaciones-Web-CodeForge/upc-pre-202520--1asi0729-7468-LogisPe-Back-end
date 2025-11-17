import { findAll, findById, create, update, remove } from "../../infrastructure/persistence/memory/suppliersRepository.js";

export const listSuppliers = () => findAll();
export const getSupplier = id => findById(id);
export const createSupplier = data => create(data);
export const updateSupplier = (id, data) => update(id, data);
export const removeSupplier = id => remove(id);