using ObjectOrientedProgram.InventoryManagementSystem;
using ObjectOrientedProgram.InvertoryManagement;
using ObjectOrientedProgram.stockManagement;
using ObjectOrientedProgram.StockManagementSystem;
using System;

namespace ObjectOrientedProgram
{
    public class Program
    {
        class program
        {
            const string INVENTORY_DATA_FILE_PATH = @"C:\Users\Admin\Desktop\opl\objectorientedprogramassign-master\ObjectOrientedProgram\ObjectOrientedProgram\InvertoryManagement\Invertory.json";
            const string INVENTORYDETAILS_DATA_FILE_PATH = @"C:\Users\Admin\Desktop\opl\objectorientedprogramassign-master\ObjectOrientedProgram\ObjectOrientedProgram\InventoryManagementSystem\InventoryDetails.json";
            const string STOCKDETAILS_DATA_FILE_PATH = @"C:\Users\Admin\Desktop\opl\objectorientedprogramassign-master\ObjectOrientedProgram\ObjectOrientedProgram\StockManagement\StockDetails.json";
            const string STOCK_DATA_FILE_PATH = @"C:\Users\Admin\Desktop\opl\objectorientedprogramassign-master\ObjectOrientedProgram\ObjectOrientedProgram\StockManagementSystem\Stock.json";
            const string COMPANY_DATA_FILE_PATH = @"C:\Users\Admin\Desktop\opl\objectorientedprogramassign-master\ObjectOrientedProgram\ObjectOrientedProgram\StockManagementSystem\Company.json";

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Select Programs\n 1.Inventory Management \n 2.Inventory Management System \n 3.Stock Management \n 4.Stock Management System");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Inventory inventory = new Inventory();
                            inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                            break;
                        case 2:
                            InventoryFactory inventoryFactory = new InventoryFactory();
                            inventoryFactory.ReadJsonFile(INVENTORYDETAILS_DATA_FILE_PATH);
                            InventoryDetails details = new InventoryDetails()

                            {
                                Name = "Baba",
                                Weight = 5,
                                Price = 25
                            };
                            inventoryFactory.AddInventory("RiceList", details);
                            //inventoryFactory.DeleteInventory("RiceList", "Baba");
                            inventoryFactory.WriteTojson(INVENTORYDETAILS_DATA_FILE_PATH);
                            break;
                        case 3:
                            Stock1 stock1 = new Stock1();
                            stock1.ReadJsonFile(STOCKDETAILS_DATA_FILE_PATH);
                            break;
                        case 4:
                            StockManagement stockManagement = new StockManagement();
                            stockManagement.ReadJsonFileStock(STOCK_DATA_FILE_PATH);
                            stockManagement.ReadJsonFileCompany(COMPANY_DATA_FILE_PATH);
                           
                            //Company company = new Company()
                            Stock stock = new Stock()
                            {
                                Name = "Facebook",
                                NoOfShares = 5,
                                PricePerShare = 250,
                            };
                            stockManagement.SellStockShares(stock);
                            //stockManagement.BuyCompanyShares(company);
                            stockManagement.WriteToJsonStock(STOCK_DATA_FILE_PATH);
                            stockManagement.WriteToJsoncompany(COMPANY_DATA_FILE_PATH);
                            break;
                    }
                }
            }

        }
    }
}

