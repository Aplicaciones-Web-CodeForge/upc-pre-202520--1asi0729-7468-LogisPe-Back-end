import { findAll, findById, create, update, remove } from "../../infrastructure/persistence/memory/usersRepository.js";

export const listUsers = () => findAll();
export const getUser = id => findById(id);
export const createUser = data => create(data);
export const updateUser = (id, data) => update(id, data);
export const removeUser = id => remove(id);