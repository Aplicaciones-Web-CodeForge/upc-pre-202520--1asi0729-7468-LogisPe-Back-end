import app from "./app.js";

const port = process.env.PORT ? Number(process.env.PORT) : 3001;
app.listen(port, () => {
  console.log(`LogisPe API running on http://localhost:${port}`);
  console.log(`Swagger UI available at http://localhost:${port}/docs`);
});