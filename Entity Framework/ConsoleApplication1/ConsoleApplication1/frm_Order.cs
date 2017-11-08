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

        public frm_Order(BindingList<Product> _products, BindingList<Customer> _customers)
        {
            InitializeComponent();
            order = new Order();
            products = _products;
            customers = _customers;
        }

        private void frm_Order_Load(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = order;
            productBindingSource1.DataSource = products;
            customerBindingSource1.DataSource = customers;
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

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
        }
    }
}
