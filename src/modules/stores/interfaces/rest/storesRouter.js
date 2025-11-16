import express from "express";
import { listStores, getStore, createStore, updateStore, removeStore } from "../../application/internal/storesService.js";

const router = express.Router();
router.get("/", (req, res) => { res.json(listStores()); });
router.get("/:id", (req, res) => { const id = Number(req.params.id); const item = getStore(id); if (!item) return res.status(404).json({ message: "stores not found" }); res.json(item); });
router.post("/", (req, res) => { const created = createStore(req.body); res.status(201).json(created); });
router.put("/:id", (req, res) => { const id = Number(req.params.id); const updated = updateStore(id, req.body); if (!updated) return res.status(404).json({ message: "stores not found" }); res.json(updated); });
router.delete("/:id", (req, res) => { const id = Number(req.params.id); const removed = removeStore(id); if (!removed) return res.status(404).json({ message: "stores not found" }); res.json(removed); });
export default router;