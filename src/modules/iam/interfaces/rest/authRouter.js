import express from "express";
import { loginUser } from "../../application/internal/authService.js";

const router = express.Router();
router.post("/login", (req, res) => {
  const { email, password } = req.body || {};
  const result = loginUser(email, password);
  if (!result) return res.status(401).json({ message: "credenciales inválidas" });
  res.json({ user: result });
});
export default router;