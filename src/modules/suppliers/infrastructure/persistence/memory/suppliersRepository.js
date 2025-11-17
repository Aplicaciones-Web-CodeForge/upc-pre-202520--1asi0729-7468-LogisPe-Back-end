export let suppliers = [
  { id: 1, name: "Proveedor Uno", email: "proveedor1@example.com", phone: "+51 900000001" },
  { id: 2, name: "Proveedor Dos", email: "proveedor2@example.com", phone: "+51 900000002" }
];

const nextId = () => (suppliers.length ? Math.max(...suppliers.map(i => i.id)) + 1 : 1);

export const findAll = () => suppliers;
export const findById = id => suppliers.find(i => i.id === id);
export const create = data => { const item = { id: nextId(), ...data }; suppliers.push(item); return item; };
export const update = (id, data) => { const idx = suppliers.findIndex(i => i.id === id); if (idx === -1) return null; suppliers[idx] = { ...suppliers[idx], ...data, id }; return suppliers[idx]; };
export const remove = id => { const idx = suppliers.findIndex(i => i.id === id); if (idx === -1) return null; const [removed] = suppliers.splice(idx, 1); return removed; };