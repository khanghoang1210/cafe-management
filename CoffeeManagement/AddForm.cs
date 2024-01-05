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
        static public CoffeeOutput selectedItem;
        static public Coffee coffee = new Coffee();
        static public bool isEdit;
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
            if (isEdit)
            {
                btnAdd.Text = "Edit";
                txtName.Text = selectedItem.Name;
                txtPrice.Text = selectedItem.Price.ToString();
                cboxCategory.Text = selectedItem.Category;
            }
            else
            {
                btnAdd.Text = "Add";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            var category = db.Categories.Where(x => x.category_name == cboxCategory.Text).FirstOrDefault();
            coffee.name = txtName.Text;
            coffee.price = Double.Parse(txtPrice.Text);
            //if (isEdit)
            //    coffee.Category.category_name = category.category_name;
            //else
            coffee.category_id = category.id;
            //db.Coffees.InsertOnSubmit(coffee);
            //db.SubmitChanges();
            MessageBox.Show(isEdit ? "Update successful." : "Add successful.", "Coffee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
