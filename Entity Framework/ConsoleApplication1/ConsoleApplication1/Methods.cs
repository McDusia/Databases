using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication1
{
    class Methods
    {
        //METODY DOSTĘPOWE
        //M w końcówce oznacza, że jest to Method Syntax, zaś Q - Query Syntax

        //Navigation Property - z tabeli Category, po zależnościach dochodzimy do Produktów
        public static void PrintCategoriesAndProductsQ(ProdContext db)
        {
            var query = from b in db.Categories
                        orderby b.Name descending
                        select b;

            foreach (var categoryName in query)
            {
                Console.WriteLine("Category name: {0}", categoryName.Name);

                foreach (Product product in categoryName.Products)
                    Console.WriteLine("description: {0}", product.Name);
            }
        }
        //Navigation Properties, wraz z kategorią nazwy produktów z danej kategorii
        public static void PrintCategoriesAndProductsM(ProdContext db)
        {
            IQueryable<Category> query = db.Categories;

            foreach (var categoryName in query)
            {
                Console.WriteLine(categoryName.Name);
                foreach (Product product in categoryName.Products)
                {
                    Console.WriteLine("Product: {0}", product.Name);
                }
            }
        }

        //dodatkowe metody
        //Lazy loading - jest domyślne
        //Navigation Property - z tabeli Orders, po zależnościach dochodzimy do Product i Customer, do szczegółów
        //Query syntax
        public static void PrintOrderWithDetails(ProdContext db)
        {
            db.Configuration.LazyLoadingEnabled = true;

            var query = from o in db.Orders
                        orderby o.OrderId descending
                        select o;

            foreach (var order in query)
            {
                Console.WriteLine("Order nr: {0}, Date: {1}, Quantity {2}, Status {3}", 
                    order.OrderId, order.Date, order.Quantity, order.Status);

                Product product = order.Product;
                Console.WriteLine("Product details: {0}, {1} {2}", product.ProductId, 
                    getCategoryName(db,product.CategoryId), product.Name);
                Customer customer = order.Customer;
                Console.WriteLine("Customer details: {0}, {1}\n", customer.CompanyName, customer.Description);
            }
        }
        
        public static string getCategoryName(ProdContext db, int id)
        {
            var name = from a in db.Categories
                          where a.CategoryId == id
                          select a;
            Category category = name.ToList().FirstOrDefault();
            return category.Name;

        }

        //Eager loading + Navigation Property
        public static void PrintOrderWithDetailsEL(ProdContext db)
        {
            var orders = db.Orders.Include(o => o.Product).Include(o => o.Customer);
            
            foreach (var order in orders)
            {
                Console.WriteLine("Order nr: {0}, Date: {1}, Quantity {2}, Status {3}",
                    order.OrderId, order.Date, order.Quantity, order.Status);

                Product product = order.Product;
                Console.WriteLine("Product details: {0}, {1}", product.ProductId, product.Name);
                Customer customer = order.Customer;
                Console.WriteLine("Customer details: {0}, {1}\n", customer.CompanyName, customer.Description);

            }

        }


        //Eager loading + Navigation Property
        public static void PrintCategoriesAndProductsEagerLoadingQ(ProdContext db)
        {
            var query = from b in db.Categories.Include("Products")
                        orderby b.Name descending
                        select b;

            foreach (var categoryName in query)
            {
                Console.WriteLine("Category name: {0}", categoryName.Name);

                foreach (Product product in categoryName.Products)
                    Console.WriteLine("description: {0}", product.Name);
            }
        }

        //+Eager loading - zapytanie o jeden typ tabeli ładuje od razu także powiązaną tabelę jako część zapytania
        //+Navigation Property
        public static void PrintCategoriesAndProductsEagerLoadingM(ProdContext db)
        {
            var categories = db.Categories
                .Include(c => c.Products)  //opcjonalnie po nazwie encji Include("Products")
                .ToList();

            foreach (var record in categories)
            {
                Console.WriteLine("Category Name: {0}", record.Name);
                foreach (var p in record.Products)
                {
                    Console.WriteLine("Product: {0}", p.Name);
                }
            }
        }

        //Join
        public static void PrintCategoriesAndProductsJoinM(ProdContext db)
        {
            var query = db.Categories
                .Join(db.Products,
                product => product.CategoryId,
                category => category.CategoryId,
                (category, product) =>
                new {
                    c = category,
                    p = product
                });

            foreach (var record in query)
            {
                Console.WriteLine("Category Name " + record.c, "Product Name " + record.p);
            }
        }
        public static void PrintCategoriesAndProductsJoinQ(ProdContext db)
        {
            var query = from ca in db.Categories
                        join pr in db.Products
                            on ca.CategoryId equals pr.CategoryId
                        //orderby c.Name
                        select new
                        {
                            c = ca,
                            p = pr
                        };

            foreach (var record in query)
            {
                Console.WriteLine("Category Name: " + record.c.Name + " Product Name: " + record.p.Name);
            }
        }


        //dodatkowe:
        public static void PrintOnlyCategoriesNamesM(ProdContext db)
        {
            List<String> categoryNames = db.Categories
                .Select(c => c.Name)
                .ToList();

            foreach (var categoryName in categoryNames)
            {
                Console.WriteLine(categoryName);
            }
        }

        public static void PrintOnlyCategoriesNamesQ(ProdContext db)
        {
            var query = from c in db.Categories
                        orderby c.Name descending
                        select c.Name;

            foreach (var categoryName in query)
            {
                Console.WriteLine(categoryName);
            }
        }

        //Agregacja - Count 
        public static void CountProductsForCategoryQ(ProdContext db)
        {
            var query = from c in db.Categories
                        orderby c.Name descending
                        select new
                        {
                            CategoryID = c.CategoryId,
                            CategoryName = c.Name,
                            ProductsQuantity = c.Products.Count()
                        };

            foreach (var c in query)
            {
                Console.WriteLine("Category Name: {0} \t ProductsQuantity: {1}",
                    c.CategoryName,
                    c.ProductsQuantity);
            }
        }

        /*public static void CountProductsForCategoryM(ProdContext db)
        {
            var query = db.Categories
                        .Select(c => c.Products).Count();
                        
                        select new
                        {
                            CategoryID = c.CategoryId,
                            CategoryName = c.Name,
                            ProductsQuantity = c.Products.Count()
                        };

            foreach (var c in query)
            {
                Console.WriteLine("Category Name: {0} \t ProductsQuantity: {1}",
                    c.CategoryName,
                    c.ProductsQuantity);
            }
        }*/

    }

    
}
