import express from "express";
import { listSuppliers, getSupplier, createSupplier, updateSupplier, removeSupplier } from "../../application/internal/suppliersService.js";

const router = express.Router();
router.get("/", (req, res) => { res.json(listSuppliers()); });
router.get("/:id", (req, res) => { const id = Number(req.params.id); const item = getSupplier(id); if (!item) return res.status(404).json({ message: "suppliers not found" }); res.json(item); });
router.post("/", (req, res) => { const created = createSupplier(req.body); res.status(201).json(created); });
router.put("/:id", (req, res) => { const id = Number(req.params.id); const updated = updateSupplier(id, req.body); if (!updated) return res.status(404).json({ message: "suppliers not found" }); res.json(updated); });
router.delete("/:id", (req, res) => { const id = Number(req.params.id); const removed = removeSupplier(id); if (!removed) return res.status(404).json({ message: "suppliers not found" }); res.json(removed); });
export default router;