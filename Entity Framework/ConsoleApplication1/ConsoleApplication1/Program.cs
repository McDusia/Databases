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

                //Console.Write("Enter a name for a new Category: ");

                //var name = Console.ReadLine();
                
                //zaistancjonuj kategorię o podanej nazwie
                //var category = new Category { Name = name };
                //dodanie zaistancjonowanego obiektu do kontekstowej kolekcji kategorii
                //db.Categories.Add(category);

                //var product = new Product { Name = "pomarańczowa", UnitsInStock = 10, CategoryId = 2, UnitPrice = 10 };
                //var customer = new Customer { CompanyName = "Lewiatan", Description = "little greengrocer's" };
                //var order = new Order { Customer = customer, Product = product, Quantity = 10, Status = 'N' };
                //db.Products.Add(product);
                //db.Customers.Add(customer);
                //db.Orders.Add(order);
                //zapisanie zmian w kontekście
                //db.SaveChanges();


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

                Console.WriteLine("Products quantity for each category:");
                
                Methods.CountProductsForCategoryQ(db);

                MainForm f = new MainForm();
                f.ShowDialog();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

      
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
        //[Key]
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

    public class Order
    {
        [Key]
        public int OrderId {get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public char Status { get; set; }
    }

    public class ProdContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
    
}
