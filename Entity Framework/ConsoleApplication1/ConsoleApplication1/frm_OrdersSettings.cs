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
    public partial class frm_OrdersSettings : Form
    {
        public Order order;

        public frm_OrdersSettings(Order _order)
        {
            InitializeComponent();
            order = _order;
        }
        
        private void frm_Orders_Load(object sender, EventArgs e)
        {
            
            orderBindingSource.DataSource = order;
            setSelectedStatus(order.Status);
        }
        
        private string getSelectedStatus()
        {
            if (RB_Nowe.Checked) return "Nowe";
            else if (RB_Zaplacone.Checked) return "Zapłacone";
            else return "Anulowane";
        }

        private void setSelectedStatus(String status)
        {
            switch(status)
            {
                case "Nowe":
                    RB_Nowe.Checked = true;
                    break;

                case "Zapłacone":
                    RB_Zaplacone.Checked = true;
                    break;

                case "Anulowane":
                    RB_Anulowane.Checked = true;
                    break;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            order.Status = getSelectedStatus();

        }
    }
}
