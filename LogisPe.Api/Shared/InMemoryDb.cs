using LogisPe.Api.Shared;

namespace LogisPe.Api.Shared;

public static class InMemoryDb
{
    public static List<User> Users = new()
    {
        new User{ Id=1, Name="Ana Perez", Email="ana@example.com", Password="123456", Role="admin" },
        new User{ Id=2, Name="Carlos Diaz", Email="carlos@example.com", Password="123456", Role="user" }
    };
    public static List<Stock> Stocks = new()
    {
        new Stock{ Id=1, Sku="SKU-001", ProductName="Producto A", Quantity=120, StoreId=1 },
        new Stock{ Id=2, Sku="SKU-002", ProductName="Producto B", Quantity=45, StoreId=1 },
        new Stock{ Id=3, Sku="SKU-003", ProductName="Producto C", Quantity=10, StoreId=2 }
    };
    public static List<Order> Orders = new()
    {
        new Order{ Id=1, OrderNumber="ORD-1001", Items=new(){ new OrderItem{ Sku="SKU-001", Quantity=2 } }, Status="pending", SupplierId=1, StoreId=1 },
        new Order{ Id=2, OrderNumber="ORD-1002", Items=new(){ new OrderItem{ Sku="SKU-002", Quantity=5 } }, Status="shipped", SupplierId=2, StoreId=1 }
    };
    public static List<Supplier> Suppliers = new()
    {
        new Supplier{ Id=1, Name="Proveedor Uno", Email="proveedor1@example.com", Phone="+51 900000001" },
        new Supplier{ Id=2, Name="Proveedor Dos", Email="proveedor2@example.com", Phone="+51 900000002" }
    };
    public static List<Store> Stores = new()
    {
        new Store{ Id=1, Name="Tienda Central", Address="Av. Principal 123" },
        new Store{ Id=2, Name="Sucursal Norte", Address="Jr. Norte 456" }
    };
}