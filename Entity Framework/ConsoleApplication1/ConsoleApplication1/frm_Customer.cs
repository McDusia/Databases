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
    public partial class frm_Customer : Form
    {
        public Customer customer;
        private Boolean created = false;

        public frm_Customer()
        {
            InitializeComponent();
        }
        

        private void frm_Customer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           string q = this.textBox1.Text;
            if (!created)
            {
                this.customer = new Customer { CompanyName = q };
                created = true;
            }
            else
            {
                this.customer.CompanyName = q;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string d = this.textBox2.Text;
            if (!created)
            {
                this.customer = new Customer { Description = d };
                created = true;
            }
            else
            {
                this.customer.Description = d;
            }
        }

        
    }
}
