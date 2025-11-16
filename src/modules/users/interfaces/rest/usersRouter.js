import express from "express";
import { listUsers, getUser, createUser, updateUser, removeUser } from "../../application/internal/usersService.js";

const router = express.Router();
router.get("/", (req, res) => { res.json(listUsers()); });
router.get("/:id", (req, res) => {
  const id = Number(req.params.id);
  const item = getUser(id);
  if (!item) return res.status(404).json({ message: "users not found" });
  res.json(item);
});
router.post("/", (req, res) => {
  const created = createUser(req.body);
  res.status(201).json(created);
});
router.put("/:id", (req, res) => {
  const id = Number(req.params.id);
  const updated = updateUser(id, req.body);
  if (!updated) return res.status(404).json({ message: "users not found" });
  res.json(updated);
});
router.delete("/:id", (req, res) => {
  const id = Number(req.params.id);
  const removed = removeUser(id);
  if (!removed) return res.status(404).json({ message: "users not found" });
  res.json(removed);
});
export default router;