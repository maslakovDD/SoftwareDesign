using lab_02;
using lab_02.Classes;
using lab_02.Classes.Currency;
using lab_02.Classes.Warehouses;
using lab_02.Classes.WarehouseManagers;
using lab_02.ExtensionMethods;
using lab_02.Interfaces;

Product milk = new("Milk", "dairy", new Hryvnia(30,50), "litre");
Product cheese = new("Cheese", "dairy", new Hryvnia(150,90), "kg");
Product butter = new("Butter", "dairy", new Hryvnia(65,75), "kg");
Product bread = new("Bread", "dairy", new Hryvnia(20,75), "kg");
Product steak = new("Steak", "meat", new Dollar(20, 50), "kg");
Warehouse dairyWarehouse = new DairyWarehouse();
Warehouse meatWarehouse = new MeatWarehouse();

IWarehouseInfo dairyWarehouseInfo = new WarehouseInfoManager(dairyWarehouse);
IWarehouseManager dairyWarehouseManager = new WarehouseManager(dairyWarehouse);

IWarehouseInfo meatWarehouseInfo = new WarehouseInfoManager(meatWarehouse);
IWarehouseManager meatWarehouseManager = new WarehouseManager(meatWarehouse);

dairyWarehouseManager.AddProduct(milk);
dairyWarehouseManager.AddProduct(cheese);
dairyWarehouseManager.AddProduct(butter);

meatWarehouseManager.AddProduct(steak);

Console.WriteLine(dairyWarehouseInfo.GetWarehouseInfo());
Console.WriteLine(dairyWarehouseInfo.GetWarehouseProductsInfo());
Console.WriteLine(meatWarehouseInfo.GetWarehouseInfo());
Console.WriteLine(meatWarehouseInfo.GetWarehouseProductsInfo());


dairyWarehouseManager.RemoveProduct(cheese);
Console.WriteLine($"Last dairy repost:");
dairyWarehouseManager.PrintReport();
dairyWarehouseManager.PrintAllReports();
Console.ReadKey();