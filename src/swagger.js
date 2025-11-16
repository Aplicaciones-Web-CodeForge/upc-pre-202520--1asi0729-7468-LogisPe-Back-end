export const openapiSpec = {
  openapi: "3.0.0",
  info: { title: "LogisPe API", version: "1.0.0" },
  servers: [{ url: "http://localhost:3001" }],
  paths: {
    "/users": {
      get: { responses: { "200": { description: "OK" } } },
      post: { requestBody: { required: true }, responses: { "201": { description: "Created" } } }
    },
    "/users/{id}": {
      get: { parameters: [{ name: "id", in: "path", required: true }], responses: { "200": { description: "OK" }, "404": { description: "Not Found" } } },
      put: { parameters: [{ name: "id", in: "path", required: true }], requestBody: { required: true }, responses: { "200": { description: "OK" }, "404": { description: "Not Found" } } },
      delete: { parameters: [{ name: "id", in: "path", required: true }], responses: { "200": { description: "OK" }, "404": { description: "Not Found" } } }
    },
    "/stocks": {
      get: { responses: { "200": { description: "OK" } } },
      post: { requestBody: { required: true }, responses: { "201": { description: "Created" } } }
    },
    "/stocks/{id}": {
      get: { parameters: [{ name: "id", in: "path", required: true }], responses: { "200": { description: "OK" } } },
      put: { parameters: [{ name: "id", in: "path", required: true }], requestBody: { required: true }, responses: { "200": { description: "OK" } } },
      delete: { parameters: [{ name: "id", in: "path", required: true }], responses: { "200": { description: "OK" } } }
    },
    "/orders": {
      get: { responses: { "200": { description: "OK" } } },
      post: { requestBody: { required: true }, responses: { "201": { description: "Created" } } }
    },
    "/orders/{id}": {
      get: { parameters: [{ name: "id", in: "path", required: true }], responses: { "200": { description: "OK" } } },
      put: { parameters: [{ name: "id", in: "path", required: true }], requestBody: { required: true }, responses: { "200": { description: "OK" } } },
      delete: { parameters: [{ name: "id", in: "path", required: true }], responses: { "200": { description: "OK" } } }
    },
    "/suppliers": {
      get: { responses: { "200": { description: "OK" } } },
      post: { requestBody: { required: true }, responses: { "201": { description: "Created" } } }
    },
    "/suppliers/{id}": {
      get: { parameters: [{ name: "id", in: "path", required: true }], responses: { "200": { description: "OK" } } },
      put: { parameters: [{ name: "id", in: "path", required: true }], requestBody: { required: true }, responses: { "200": { description: "OK" } } },
      delete: { parameters: [{ name: "id", in: "path", required: true }], responses: { "200": { description: "OK" } } }
    },
    "/stores": {
      get: { responses: { "200": { description: "OK" } } },
      post: { requestBody: { required: true }, responses: { "201": { description: "Created" } } }
    },
    "/stores/{id}": {
      get: { parameters: [{ name: "id", in: "path", required: true }], responses: { "200": { description: "OK" } } },
      put: { parameters: [{ name: "id", in: "path", required: true }], requestBody: { required: true }, responses: { "200": { description: "OK" } } },
      delete: { parameters: [{ name: "id", in: "path", required: true }], responses: { "200": { description: "OK" } } }
    },
    "/auth/login": {
      post: { requestBody: { required: true }, responses: { "200": { description: "OK" }, "401": { description: "Unauthorized" } } }
    }
  }
};