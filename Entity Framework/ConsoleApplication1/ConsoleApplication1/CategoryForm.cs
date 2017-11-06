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
    public partial class CategoryForm : Form
    {
        private ProdContext db = new ProdContext();

        public CategoryForm()
        {
            InitializeComponent();
        }

        //Load to domyślny Event całego formularza
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            //ładuje do bufora danych do kliencie z serwera bazy danych
            db.Categories.Load();
            //połaczenie kontrolki z danymi z Entity Framework 
            categoryBindingSource.DataSource = db.Categories.Local.ToBindingList();
            
        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //po kliknięciu na komórkę z Categories
            string a;
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
            //            var query = from p in db.Products
            //                join c in db.Categories on p.CategoryId equals c.CategoryId
            //                where c.CategoryId == categoryId
            //                select p;
            // List<Product> products = query.ToList<Product>();

        }


        private void Category_Add(object sender, EventArgs e)
        {
            
        }

        private void Category_Save(object sender, EventArgs e)
        {
            db.SaveChanges();
            this.categoryDataGridView.Refresh();
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
