using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class AddForm : Form
    {
        CoffeeDBDataContext db = new CoffeeDBDataContext();
        public AddForm()
        {
            InitializeComponent();
            var categories = db.Categories.ToList();
            List<string> listCategories = new List<string>();
            foreach (var category in categories)
            {
                listCategories.Add(category.category_name);
            }
            cboxCategory.DataSource = listCategories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            var category = db.Categories.Where(x => x.category_name == cboxCategory.Text).FirstOrDefault();
            coffee.name = txtName.Text;
            coffee.price = Double.Parse(txtPrice.Text);
            coffee.category_id = category.id;
            db.Coffees.InsertOnSubmit(coffee);
            db.SubmitChanges();
            MessageBox.Show("Add successful.", "Coffee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
