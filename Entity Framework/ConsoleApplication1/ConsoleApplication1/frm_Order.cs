using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class frm_Order : Form
    {
        public Order order;
        private Boolean created = false;
        BindingList<Product> products;
        BindingList<Customer> customers;
        BindingList<Category> categories;

        public frm_Order(BindingList<Product> _products, BindingList<Customer> _customers, BindingList<Category> _categories)
        {
            InitializeComponent();
            order = new Order();
            products = _products;
            customers = _customers;
            categories = _categories;
            
        }

        private void frm_Order_Load(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = order;
            productBindingSource1.DataSource = products;
            customerBindingSource1.DataSource = customers;
            categoryBindingSource.DataSource = categories;
            //tu jest załadowania 
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            string tmp = this.quantityTextBox.Text;
            if (tmp == "")
                tmp = "0";
            int q = Convert.ToInt32(tmp);
            if (!created)
            {
                this.order = new Order { Quantity = q };
                created = true;
            }
            else
            {
                this.order.Quantity = q;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            int ProductId = (int)productComboBox.SelectedValue;
            order.Product = new Product() { ProductId = ProductId };
            string CompanyName = (string)customerComboBox.SelectedValue;
            order.Customer = new Customer() { CompanyName = CompanyName };
            order.Date = DateTime.Now;
            order.Status = "Nowe";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        /*private void categoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //zmieniło się
            //int CategoryId = (int)categoryComboBox.SelectedValue;
            int a = 7;
        }*/

        private void categoryComboBox_SelectedChangeCommited(object sender, EventArgs e)
        {
            
            int CategoryId = (int)categoryComboBox.SelectedValue;
            filterProducts(CategoryId);
            
        }

        private void filterProducts(int categoryId)
        {

            //method syntax
            var p = this.products
                .Where(product => product.CategoryId == categoryId)
                .ToList();
            productBindingSource1.DataSource = p;
            

            //query
            //  var query = from p in db.Products
            //    join c in db.Categories on p.CategoryId equals c.CategoryId
            //    where c.CategoryId == categoryId
            //    select p;
            //List<Product> products = query.ToList<Product>();

        }


        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
