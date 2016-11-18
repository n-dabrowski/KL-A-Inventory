using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using testerino.Data;
using System;
using System.Linq;

namespace testerino.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if(context.Inventory.Any())
                {
                    return;
                }

                context.Inventory.AddRange(

                    new Inventory
                    {
                        Name = "Monitor",
                        Category = "Electronics",
                        StorageLocation = "Unknown",
                        TotalQuantity = 78,
                        QuantityRemaining = 0,
                        RequestSubmitted = false
                    },

                    new Inventory
                    {
                        Name = "Keyboard",
                        Category = "Electronics",
                        StorageLocation = "Unknown",
                        TotalQuantity = 50,
                        QuantityRemaining = 1,
                        RequestSubmitted = false
                    },

                    new Inventory
                    {
                        Name = "Laptop",
                        Category = "Electronics",
                        StorageLocation = "Unknown",
                        TotalQuantity = 50,
                        QuantityRemaining = 0,
                        RequestSubmitted = false
                    },

                    new Inventory
                    {
                        Name = "Standing Desk",
                        Category = "Furniture",
                        StorageLocation = "Unknown",
                        TotalQuantity = 78,
                        QuantityRemaining = 0,
                        RequestSubmitted = false
                    },

                    new Inventory
                    {
                        Name = "Desk Chair",
                        Category = "Furniture",
                        StorageLocation = "Unknown",
                        TotalQuantity = 100,
                        QuantityRemaining = 0,
                        RequestSubmitted = false
                    },

                    new Inventory
                    {
                        Name = "Power Strip",
                        Category = "Electronics",
                        StorageLocation = "Unknown",
                        TotalQuantity = 78,
                        QuantityRemaining = 0,
                        RequestSubmitted = false
                    },

                    new Inventory
                    {
                        Name = "Paper",
                        Category = "Paper",
                        StorageLocation = "Closet",
                        QuantityRemaining = 1000,
                        RequestSubmitted = false
                    },

                    new Inventory
                    {
                        Name = "Pens",
                        Category = "Office Supplies",
                        StorageLocation = "Closet",
                        QuantityRemaining = 10,
                        RequestSubmitted = false
                    },

                    new Inventory
                    {
                        Name = "Scissors",
                        Category = "Office Supplies",
                        StorageLocation = "Unknown",
                        TotalQuantity = 1,
                        RequestSubmitted = false
                    },

                    new Inventory
                    {
                        Name = "Ping Pong Table",
                        Category = "Furniture",
                        StorageLocation = "Break Room",
                        TotalQuantity = 1,
                        RequestSubmitted = false
                    }




                    );
                context.SaveChanges();
            }
        }
    }
}
