import express from "express";
import { listOrders, getOrder, createOrder, updateOrder, removeOrder } from "../../application/internal/ordersService.js";

const router = express.Router();
router.get("/", (req, res) => { res.json(listOrders()); });
router.get("/:id", (req, res) => { const id = Number(req.params.id); const item = getOrder(id); if (!item) return res.status(404).json({ message: "orders not found" }); res.json(item); });
router.post("/", (req, res) => { const created = createOrder(req.body); res.status(201).json(created); });
router.put("/:id", (req, res) => { const id = Number(req.params.id); const updated = updateOrder(id, req.body); if (!updated) return res.status(404).json({ message: "orders not found" }); res.json(updated); });
router.delete("/:id", (req, res) => { const id = Number(req.params.id); const removed = removeOrder(id); if (!removed) return res.status(404).json({ message: "orders not found" }); res.json(removed); });
export default router;