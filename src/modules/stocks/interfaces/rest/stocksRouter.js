import express from "express";
import { listStocks, getStock, createStock, updateStock, removeStock } from "../../application/internal/stocksService.js";

const router = express.Router();
router.get("/", (req, res) => { res.json(listStocks()); });
router.get("/:id", (req, res) => { const id = Number(req.params.id); const item = getStock(id); if (!item) return res.status(404).json({ message: "stocks not found" }); res.json(item); });
router.post("/", (req, res) => { const created = createStock(req.body); res.status(201).json(created); });
router.put("/:id", (req, res) => { const id = Number(req.params.id); const updated = updateStock(id, req.body); if (!updated) return res.status(404).json({ message: "stocks not found" }); res.json(updated); });
router.delete("/:id", (req, res) => { const id = Number(req.params.id); const removed = removeStock(id); if (!removed) return res.status(404).json({ message: "stocks not found" }); res.json(removed); });
export default router;