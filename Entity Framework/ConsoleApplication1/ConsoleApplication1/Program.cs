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
    class Program
    {


        static void Main(string[] args)
        {
            using (var db = new ProdContext())
            {
                var wasCreated = db.Database.CreateIfNotExists();
                db.Database.Connection.Open();
                //Create and save a new Category
                Console.Write("Enter a name for a new Category: ");
                var name = Console.ReadLine();
                //zaistancjonuj kategorię o podanej nazwie
                var category = new Category { Name = name };
                //dodanie zaistancjonowanego obiektu do kontekstowej kolekcji kategorii
                db.Categories.Add(category);
                //zapisanie zmian w kontekście
                db.SaveChanges();


                //List<string> c=db.Categories.Where(a => a.Name.Length >0).Select(a => a.Name).ToList();

                //V. method based syntax
                var categories = db.Categories
                    .Select(c => c.Name).ToList();
                   
                Console.WriteLine("Categories Names:");
                foreach (String c in categories)
                {
                    Console.WriteLine(c);
                }


                //Display all Categories from the database
                var query = from b in db.Categories
                            orderby b.Name descending
                            select b;

                Console.WriteLine("All categories in the database (method syntax):");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
                
                CategoryForm f = new CategoryForm();
                f.ShowDialog();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        //METODY DOSTĘPOWE
        //M w końcówce oznacza, że jest to Method Syntax, zaś Q - Query Syntax
        
        //Navigation Property - z tabeli Category, po zależnościach dochodzimy do Produktów
        private static void PrintCategoriesAndProductsQ(ProdContext db)
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
        private static void PrintCategoriesAndProductsM(ProdContext db)
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


        //Eager loading + Navigation Property
        private static void PrintCategoriesAndProductsEagerLoadingQ(ProdContext db)
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
        private static void PrintCategoriesAndProductsEagerLoadingM(ProdContext db)
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
        private static void PrintCategoriesAndProductsJoinM(ProdContext db)
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
        private static void PrintCategoriesAndProductsJoinQ(ProdContext db)
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
        private static void PrintOnlyCategoriesNamesM(ProdContext db)
        {
            List<String> categoryNames = db.Categories
                .Select(c => c.Name)
                .ToList();

            foreach (var categoryName in categoryNames)
            {
                Console.WriteLine(categoryName);
            }
        }
        
        private static void PrintOnlyCategoriesNamesQ(ProdContext db)
        {
            var query = from c in db.Categories
                        orderby c.Name descending
                        select c.Name;

            foreach (var categoryName in query)
            {
                Console.WriteLine(categoryName);
            }
        }

        //Agregacja - Count //Any ?? jak dodać żeby zwracało 0 gdy nie ma produktów??
        private static void CountProductsForCategoryQ(ProdContext db)
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

        /*private static void CountProductsForCategoryM(ProdContext db)
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

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; }
    }

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }

        //public virtual Category Category { get; set; }
    }

    public class Customer
    {
        [Key]
        public string CompanyName { get; set; }
        public string Description { get; set; }

        //public virtual Category Category { get; set; }
    }

    public class ProdContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }

    


}
