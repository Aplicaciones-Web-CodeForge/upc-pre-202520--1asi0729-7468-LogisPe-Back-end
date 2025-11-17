export let stocks = [
  { id: 1, sku: "SKU-001", productName: "Producto A", quantity: 120, storeId: 1 },
  { id: 2, sku: "SKU-002", productName: "Producto B", quantity: 45, storeId: 1 },
  { id: 3, sku: "SKU-003", productName: "Producto C", quantity: 10, storeId: 2 }
];

const nextId = () => (stocks.length ? Math.max(...stocks.map(i => i.id)) + 1 : 1);

export const findAll = () => stocks;
export const findById = id => stocks.find(i => i.id === id);
export const create = data => { const item = { id: nextId(), ...data }; stocks.push(item); return item; };
export const update = (id, data) => { const idx = stocks.findIndex(i => i.id === id); if (idx === -1) return null; stocks[idx] = { ...stocks[idx], ...data, id }; return stocks[idx]; };
export const remove = id => { const idx = stocks.findIndex(i => i.id === id); if (idx === -1) return null; const [removed] = stocks.splice(idx, 1); return removed; };