using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using InventoryManagementProject.Models;

namespace InventoryManagementProject.Helpers
{
    public class FirebaseHelper
    {
        private readonly FirebaseClient firebase = new FirebaseClient("https://oop-inventory-management-default-rtdb.asia-southeast1.firebasedatabase.app/");

        public async Task AddProduct(Product product)
        {
            await firebase.Child("Products").PostAsync(product);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var products = await firebase
                .Child("Products")
                .OnceAsync<Product>();

            return products.Select(p => p.Object).ToList();
        }

        public async Task UpdateProduct(string key, Product product)
        {
            await firebase.Child("Products").Child(key).PutAsync(product);
        }

        public async Task DeleteProduct(string key)
        {
            await firebase.Child("Products").Child(key).DeleteAsync();
        }

        public async Task<string> GetProductKeyByProductID(string productId)
        {
            var products = await firebase
                .Child("Products")
                .OnceAsync<Product>();

            var match = products.FirstOrDefault(p => p.Object.ProductID == productId);
            return match?.Key;
        }

        public async Task DeleteProductByProductID(string productId)
        {
            var key = await GetProductKeyByProductID(productId);
            if (key != null)
            {
                await firebase.Child("Products").Child(key).DeleteAsync();
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var toUpdate = (await firebase
                .Child("Products")
                .OnceAsync<Product>())
                .FirstOrDefault(p => p.Object.ProductID == product.ProductID);

            if (toUpdate != null)
            {
                await firebase
                    .Child("Products")
                    .Child(toUpdate.Key)
                    .PutAsync(product);
            }
        }
        public async Task UpdateProductQuantity(string productId, int newQty)
        {
            var products = await firebase
                .Child("Products")
                .OnceAsync<Product>();

            var match = products.FirstOrDefault(p => p.Object.ProductID == productId);

            if (match != null)
            {
                var product = match.Object;
                product.Quantity = newQty;

                await firebase
                    .Child("Products")
                    .Child(match.Key) 
                    .PutAsync(product);
            }
        }
        public async Task<List<Transaction>> GetAllTransactions()
        {
            var allTransactions = await firebase
                .Child("Transactions")
                .OnceAsync<Transaction>();

            return allTransactions.Select(t => new Transaction
            {
                ReferenceNo = t.Object.ReferenceNo,
                Type = t.Object.Type,
                Date = t.Object.Date,
                Category = t.Object.Category,
                Supplier = t.Object.Supplier,
                Products = t.Object.Products ?? new List<TransactionProduct>(),
                TotalAmount = t.Object.TotalAmount
            }).ToList();
        }
        public async Task SaveTransaction(Transaction transaction)
        {
            await firebase
                .Child("Transactions")
                .Child(transaction.ReferenceNo) // use ReferenceNo as key
                .PutAsync(transaction);         // use PutAsync to overwrite/create
        }
        public async Task<List<Report>> GetAllReports()
        {
            var salesReports = await firebase
         .Child("sales")
         .OnceAsync<SalesReport>();

            var stockReports = await firebase
                .Child("stock")
                .OnceAsync<StockReport>();

            var allReports = new List<Report>();

            allReports.AddRange(salesReports.Select(s =>
            {
                var r = s.Object;
                r.ReportID = s.Key;
                return (Report)r;
            }));

            allReports.AddRange(stockReports.Select(s =>
            {
                var r = s.Object;
                r.ReportID = s.Key;
                return (Report)r;
            }));

            return allReports.OrderByDescending(r => r.ReportDate).ToList();
        }

        public async Task AddReport(Report report)
        {
            string node = report.ReportType.ToLower(); // "sales" or "stock"
            await firebase
                .Child(node)
                .Child(report.ReportID)
                .PutAsync(report);
        }
        public async Task SaveSale(Transaction sale)
        {
            await firebase
                .Child("Sales")
                .Child(sale.ReferenceNo)
                .PutAsync(sale);
        }

        public async Task DeleteReport(string reportID)
        {
            await firebase
                .Child("Reports")
                .Child(reportID)
                .DeleteAsync();
        }
        public async Task<List<Transaction>> GetAllSales()
        {
            var sales = await firebase
                .Child("Sales")
                .OnceAsync<Transaction>();

            return sales.Select(s => s.Object).ToList();
        }
        public async Task<int> GetProductCount()
        {
            var products = await firebase.Child("Products").OnceAsync<Product>();
            return products.Count;
        }

        public async Task<int> GetTransactionCount()
        {
            var transactions = await firebase.Child("Transactions").OnceAsync<Transaction>();
            return transactions.Count;
        }

        public async Task<int> GetSalesCount()
        {
            var sales = await firebase.Child("Sales").OnceAsync<Transaction>();
            return sales.Count;
        }
        public async Task<double> GetTotalSalesRevenue()
        {
            var sales = await firebase.Child("Sales").OnceAsync<Transaction>();
            return sales.Sum(s => s.Object.TotalAmount);
        }

    }
}
