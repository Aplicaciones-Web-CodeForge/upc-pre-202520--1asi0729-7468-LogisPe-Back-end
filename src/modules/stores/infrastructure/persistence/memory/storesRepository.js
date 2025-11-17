export let stores = [
  { id: 1, name: "Tienda Central", address: "Av. Principal 123" },
  { id: 2, name: "Sucursal Norte", address: "Jr. Norte 456" }
];

const nextId = () => (stores.length ? Math.max(...stores.map(i => i.id)) + 1 : 1);

export const findAll = () => stores;
export const findById = id => stores.find(i => i.id === id);
export const create = data => { const item = { id: nextId(), ...data }; stores.push(item); return item; };
export const update = (id, data) => { const idx = stores.findIndex(i => i.id === id); if (idx === -1) return null; stores[idx] = { ...stores[idx], ...data, id }; return stores[idx]; };
export const remove = id => { const idx = stores.findIndex(i => i.id === id); if (idx === -1) return null; const [removed] = stores.splice(idx, 1); return removed; };