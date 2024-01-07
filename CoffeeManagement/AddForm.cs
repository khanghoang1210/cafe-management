using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class AddForm : Form
    {
        static public CoffeeOutput selectedItem;
        static public Coffee coffee;
        static public bool isEdit;
        private readonly CoffeeDBDataContext db = new CoffeeDBDataContext();

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
                lblAdd.Text = "Edit Item";
                txtName.Text = selectedItem.Name;
                txtPrice.Text = selectedItem.Price.ToString();
                cboxCategory.Text = selectedItem.Category;
            }
            else
            {
                btnAdd.Text = "Add";
                lblAdd.Text = "Add New Item";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                var cate = db.Categories.Where(x => x.category_name == cboxCategory.Text).FirstOrDefault();
                //coffee.name = txtName.Text;
                //coffee.price = Double.Parse(txtPrice.Text);
                //coffee.Category = cate;
                selectedItem.Name = txtName.Text;
                selectedItem.Price = Double.Parse(txtPrice.Text);
                selectedItem.Category = cboxCategory.Text;
                MessageBox.Show("Update successful.", "Update Coffee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                var category = db.Categories.Where(x => x.category_name == cboxCategory.Text).FirstOrDefault();
                coffee.name = txtName.Text;
                coffee.price = Double.Parse(txtPrice.Text);
                coffee.category_id = category.id;
                db.Coffees.InsertOnSubmit(coffee);
                db.SubmitChanges();
                MessageBox.Show("Add successful.", "Add Coffee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
