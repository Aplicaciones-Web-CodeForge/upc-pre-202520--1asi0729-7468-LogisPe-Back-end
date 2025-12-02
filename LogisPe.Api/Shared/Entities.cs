namespace LogisPe.Api.Shared;

public class User { public int Id { get; set; } public string Name { get; set; } = ""; public string Email { get; set; } = ""; public string Password { get; set; } = ""; public string Role { get; set; } = "user"; }
public class Stock { public int Id { get; set; } public string Sku { get; set; } = ""; public string ProductName { get; set; } = ""; public int Quantity { get; set; } public int StoreId { get; set; } }
public class OrderItem { public string Sku { get; set; } = ""; public int Quantity { get; set; } }
public class Order { public int Id { get; set; } public string OrderNumber { get; set; } = ""; public List<OrderItem> Items { get; set; } = new(); public string Status { get; set; } = "pending"; public int SupplierId { get; set; } public int StoreId { get; set; } public DateTime CreatedAt { get; set; } = DateTime.UtcNow; }
public class Supplier { public int Id { get; set; } public string Name { get; set; } = ""; public string Email { get; set; } = ""; public string Phone { get; set; } = ""; }
public class Store { public int Id { get; set; } public string Name { get; set; } = ""; public string Address { get; set; } = ""; }