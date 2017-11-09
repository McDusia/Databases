using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ConsoleApplication1
{
    public partial class MainForm : Form
    {
        private ProdContext db = new ProdContext();
        BindingList<Product> products;
        BindingList<Customer> customers;
        BindingList<Category> categories;
        BindingList<Order> orders;

        public MainForm()
        {
            InitializeComponent();
        }

        //Load to domyślny Event całego formularza
        private void MainForm_Load(object sender, EventArgs e)
        {
            //ładuje do bufora danych na kliencie z serwera bazy danych
            db.Categories.Load();
            //połaczenie kontrolki z danymi z Entity Framework 
            categoryBindingSource.DataSource = db.Categories.Local.ToBindingList();
            categories = db.Categories.Local.ToBindingList();

            db.Products.Load();
            products = db.Products.Local.ToBindingList();
            productBindingSource.DataSource = products;

            db.Customers.Load();
            customers = db.Customers.Local.ToBindingList();

            db.Orders.Load();
            orders = db.Orders.Local.ToBindingList();
            orderBindingSource.DataSource = orders;

        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //po kliknięciu na komórkę z nazwą kategorii
            if (e.ColumnIndex == 1)
            {   
                var categoryId = Convert.ToInt32(categoryDataGridView.Rows[e.RowIndex].Cells[0].Value);
                filterProductsQNP(categoryId);
            }

        }
        //Navigation Property, po zależnościach dochodzimy od wybranej kategorii do jej produktów
        private void filterProductsQNP(int categoryId)
        {
            var query = from b in db.Categories
                        where b.CategoryId == categoryId
                        select b;

            foreach (var categoryName in query)
            {
                List<Product> products = categoryName.Products;
                productDataGridView.DataSource = products;
            }
        }

        private void filterProducts(int categoryId)
        {   
            //query
            var query = from p in db.Products
                join c in db.Categories on p.CategoryId equals c.CategoryId
                where c.CategoryId == categoryId
                select p;
             List<Product> products = query.ToList<Product>();
            productDataGridView.DataSource = products;

            //method syntax
            /*var products = db.Products
                .Where(product => product.CategoryId == categoryId)
                .ToList();
            productDataGridView.DataSource = products;
            */
        }



        private void Category_Add(object sender, EventArgs e)
        {
            
        }

        private void Order_Add(object sender, EventArgs e)
        {
            frm_Order f = new frm_Order(products, customers, categories);
            DialogResult res=f.ShowDialog(this);
            if (res==DialogResult.OK)
            {
               
                Order o = f.order;
                if(getProductQuantity(o.Product.ProductId)<o.Quantity)
                    errorProvider1.SetError(AddOrder, "No enough products in shop");
                else
                {
                    Product p = db.Products.Local.FirstOrDefault(pr => pr.ProductId == f.order.Product.ProductId);
                    o.Product = p;
                    Customer customer = db.Customers.Local.FirstOrDefault(c => c.CompanyName == f.order.Customer.CompanyName);
                    o.Customer = customer;
                    db.Orders.Add(o);

                    db.SaveChanges();
                    orderDataGridView.Refresh();
                    errorProvider1.SetError(AddOrder, "");
                }
                
            }
        }

        private void Order_Save(object sender, EventArgs e)
        {
            db.SaveChanges();
            this.orderDataGridView.Refresh();
        }

        private void Category_Save(object sender, EventArgs e)
        {
            db.SaveChanges();
            this.categoryDataGridView.Refresh();
        }

        

        private void Delete(object sender, EventArgs e)
        {
            db.SaveChanges();
            this.orderDataGridView.Refresh();
        }

        private void bindingNavigatorDeleteItem_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void newClient_Click(object sender, EventArgs e)
        {
            frm_Customer f = new frm_Customer();
            DialogResult res = f.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                Customer c = f.customer;
                if(isCustomeCorrect(c))
                {
                    db.Customers.Add(c);
                    db.SaveChanges();
                    errorProvider1.SetError(NewClient, "");
                }
                else
                {
                    errorProvider1.SetError(NewClient, "Client already exists");
                    //alert, że już jest taki klient w bazie
                }
            }
        }
        
        private bool isCustomeCorrect(Customer c)
        {
            var customer = db.Customers.FirstOrDefault(cus => cus.CompanyName == c.CompanyName);
            return customer == null;
        }

        
        //zastosowanie Immediate Query Execution
        //wykorzystano tzw. metodę terminalną ToList(), 
        //rezultat staje się zmaterializowany, 
        //i tym samym załadowany do pamięci procesu tego programu
        private bool isCustomerCorrectQ(Customer c)
        {
            //query base syntax
              var query = from cus in db.Customers
                where cus.CompanyName == c.CompanyName
                select cus;
            List<Customer> customer = query.ToList<Customer>();

            return customer == null;
        }

        //check
        //zastosowanie immediate query execution
        //qntReserved to pojedyncza wartość, aby ją zwrócić zapytanie musi zostać
        //wykonane od razu
        private int getProductQuantity(int id)
        {
            var product = db.Products.FirstOrDefault(p => p.ProductId == id);
            int qnt = product.UnitsInStock;
            var Orders = db.Orders.Where(o => o.Product.ProductId == id).ToList<Order>();
            var qntReserved = 0;
            if (Orders != null) 
                qntReserved = Orders.Sum(o => o.Quantity);
            return qnt - qntReserved;
            
        }

       
        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void changeOrder_Click(object sender, EventArgs e)
        {
            var rows = orderDataGridView.SelectedRows;
            int OrderId = (int)((DataGridViewRow)rows[0]).Cells[0].Value;
            var Order = from o in orders
                            where o.OrderId == OrderId
                            select o;
            var order = Order.First();

            frm_OrdersSettings f = new frm_OrdersSettings(order);
            DialogResult res = f.ShowDialog(this);
            if (res == DialogResult.OK)
            {
               db.SaveChanges();
               orderDataGridView.Refresh();
            }
        }

        //zastosowanie Deferred Execution 
        //zapytanie jest "zawieszone w powietrzu"
        //"Entity Framework won’t execute the query against the database until 
        //  it needs the first result. During the first iteration of the foreach loop, 
        //  the query is sent to the database."
        //Method Syntax

        private void DeleteExpiredOrders(object sender, EventArgs e)
        {
            DateTime WeekAgo = DateTime.Now.AddDays(-7);
            var orders = db.Orders
                .Where(o => o.Status == "Nowe" && o.Date < WeekAgo);
             
            foreach(var o in orders )
            {
                o.Status = "Anulowane";
            }
            db.SaveChanges();
            this.orderDataGridView.Refresh();

        }

       
        private void filterOrdersQ()
        {
            var query = from o in db.Orders
                        where(o.Status =="Anulowane")
                        select o;
            List<Order> orders = query.ToList<Order>();
            orderDataGridView.DataSource = orders;
            
        }


        private void N_filterOrders(object sender, EventArgs e)
        {
            var query = from o in db.Orders
                        where (o.Status == "Nowe")
                        select o;
            List<Order> orders = query.ToList<Order>();
            orderDataGridView.DataSource = orders;
        }

        private void A_filterOrders(object sender, EventArgs e)
        {
            var query = from o in db.Orders
                        where (o.Status == "Anulowane")
                        select o;
            List<Order> orders = query.ToList<Order>();
            orderDataGridView.DataSource = orders;
        }

        private void Z_filterOrders(object sender, EventArgs e)
        {
            var query = from o in db.Orders
                        where (o.Status == "Zapłacone")
                        select o;
            List<Order> orders = query.ToList<Order>();
            orderDataGridView.DataSource = orders;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void All_Click(object sender, EventArgs e)
        {
            orderDataGridView.DataSource = orders;
        }

        private void Enable_ChangeOrderStatus(object sender, EventArgs e)
        {
            var rows = orderDataGridView.SelectedRows;
            changeOrder.Enabled = rows.Count > 0;
            

        }
    }
}
