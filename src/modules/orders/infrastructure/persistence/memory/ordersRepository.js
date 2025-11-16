export let orders = [
  { id: 1, orderNumber: "ORD-1001", items: [{ sku: "SKU-001", quantity: 2 }], status: "pending", supplierId: 1, storeId: 1, createdAt: new Date().toISOString() },
  { id: 2, orderNumber: "ORD-1002", items: [{ sku: "SKU-002", quantity: 5 }], status: "shipped", supplierId: 2, storeId: 1, createdAt: new Date().toISOString() }
];

const nextId = () => (orders.length ? Math.max(...orders.map(i => i.id)) + 1 : 1);

export const findAll = () => orders;
export const findById = id => orders.find(i => i.id === id);
export const create = data => { const item = { id: nextId(), ...data }; orders.push(item); return item; };
export const update = (id, data) => { const idx = orders.findIndex(i => i.id === id); if (idx === -1) return null; orders[idx] = { ...orders[idx], ...data, id }; return orders[idx]; };
export const remove = id => { const idx = orders.findIndex(i => i.id === id); if (idx === -1) return null; const [removed] = orders.splice(idx, 1); return removed; };