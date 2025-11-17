import express from "express";
import cors from "cors";
import { openapiSpec } from "./swagger.js";
import swaggerUi from "swagger-ui-express";
import usersRoutes from "./modules/users/interfaces/rest/usersRouter.js";
import stocksRoutes from "./modules/stocks/interfaces/rest/stocksRouter.js";
import ordersRoutes from "./modules/orders/interfaces/rest/ordersRouter.js";
import suppliersRoutes from "./modules/suppliers/interfaces/rest/suppliersRouter.js";
import storesRoutes from "./modules/stores/interfaces/rest/storesRouter.js";
import authRoutes from "./modules/iam/interfaces/rest/authRouter.js";

const app = express();
app.use(cors({ origin: true }));
app.use(express.json());

app.get("/health", (req, res) => {
  res.json({ status: "ok" });
});

app.get("/", (req, res) => {
  res.redirect("/docs");
});

app.use("/auth", authRoutes);
app.use("/users", usersRoutes);
app.use("/stocks", stocksRoutes);
app.use("/orders", ordersRoutes);
app.use("/suppliers", suppliersRoutes);
app.use("/stores", storesRoutes);

app.use("/docs", swaggerUi.serve, swaggerUi.setup(openapiSpec));

export default app;