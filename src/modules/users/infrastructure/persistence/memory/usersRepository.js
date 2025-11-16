export let users = [
  { id: 1, name: "Ana Perez", email: "ana@example.com", password: "123456", role: "admin" },
  { id: 2, name: "Carlos Diaz", email: "carlos@example.com", password: "123456", role: "user" }
];

const nextId = () => (users.length ? Math.max(...users.map(i => i.id)) + 1 : 1);

export const findAll = () => users;
export const findById = id => users.find(i => i.id === id);
export const create = data => {
  const item = { id: nextId(), ...data };
  users.push(item);
  return item;
};
export const update = (id, data) => {
  const idx = users.findIndex(i => i.id === id);
  if (idx === -1) return null;
  users[idx] = { ...users[idx], ...data, id };
  return users[idx];
};
export const remove = id => {
  const idx = users.findIndex(i => i.id === id);
  if (idx === -1) return null;
  const [removed] = users.splice(idx, 1);
  return removed;
};