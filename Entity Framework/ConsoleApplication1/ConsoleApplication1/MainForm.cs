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

        public MainForm()
        {
            InitializeComponent();
        }

        //Load to domyślny Event całego formularza
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            //ładuje do bufora danych na kliencie z serwera bazy danych
            db.Categories.Load();
            //połaczenie kontrolki z danymi z Entity Framework 
            categoryBindingSource.DataSource = db.Categories.Local.ToBindingList();

            db.Products.Load();
            //połaczenie kontrolki z danymi z Entity Framework 
            products = db.Products.Local.ToBindingList();
            productBindingSource.DataSource = products;
            db.Customers.Load();
            customers = db.Customers.Local.ToBindingList();
        }

        /*private void CategoryForm_AddOrder(object sender, DataGridViewCellEventArgs e)
        {
            var productId = Convert.ToInt32(productDataGridView.Rows[e.RowIndex].Cells[0].Value);
            var product = db.Products
                .Where(p => p.ProductId == productId);
                
            //productDataGridView.DataSource = products;
            
        }*/

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //po kliknięciu na komórkę z Categories
            
            if (e.ColumnIndex == 1)
            {    //a = e.ToString();

                var categoryId = Convert.ToInt32(categoryDataGridView.Rows[e.RowIndex].Cells[0].Value);
                filterProducts(categoryId);
            }

        }

        private void filterProducts(int categoryId)
        {
            
            //method syntax
            var products = db.Products
                .Where(product => product.CategoryId == categoryId)
                .ToList();
            productDataGridView.DataSource = products;

            //query
                      //  var query = from p in db.Products
                        //    join c in db.Categories on p.CategoryId equals c.CategoryId
                        //    where c.CategoryId == categoryId
                        //    select p;
             //List<Product> products = query.ToList<Product>();

        }


        private void Category_Add(object sender, EventArgs e)
        {
            
        }

        private void Order_Add(object sender, EventArgs e)
        {
            frm_Order f = new frm_Order(products, customers);
            DialogResult res=f.ShowDialog(this);
            if (res==DialogResult.OK)
            {
                Order o = f.order;
                Product p = db.Products.Local.FirstOrDefault(pr => pr.ProductId == f.order.Product.ProductId);
                o.Product = p;
                Customer customer = db.Customers.Local.FirstOrDefault(c => c.CompanyName == f.order.Customer.CompanyName);
                o.Customer = customer;
                db.Orders.Add(o);

                db.SaveChanges();
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

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoryDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Delete(object sender, EventArgs e)
        {
            db.SaveChanges();
            this.orderDataGridView.Refresh();
        }

        private void bindingNavigatorDeleteItem_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Customer f = new frm_Customer();
            DialogResult res = f.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                Customer c = f.customer;
                if(correctNewCustomer(c))
                {
                    db.Customers.Add(c);
                    db.SaveChanges();
                }
                else
                {
                    //stworzyć alert, że już jest taki klient w bazie
                }
            }
        }

        private bool correctNewCustomer(Customer c)
        {
            var customers = db.Customers
                .Where(cus => cus.CompanyName == c.CompanyName)
                .ToList();

            if (customers != null)
                return true;
            else return false;
           
        }

        private bool correctNewCustomerQ(Customer c)
        {
            //query base syntax
              var query = from cus in db.Customers
                where cus.CompanyName == c.CompanyName
                select cus;
            List<Customer> products = query.ToList<Customer>();
            if (products != null)
                return true;
            else return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
