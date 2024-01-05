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
    public partial class UpdateForm : Form
    {
        CoffeeDBDataContext db = new CoffeeDBDataContext();
        BindingSource dts = new BindingSource();
        CoffeeOutput selectedItem = new CoffeeOutput();
        public UpdateForm()
        {
            InitializeComponent();

            dvgCoffee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgCoffee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dvgCoffee.AllowUserToOrderColumns = true;
            dvgCoffee.AllowUserToResizeColumns = true;
            dvgCoffee.ReadOnly = true;
            dvgCoffee.DataSource = dts;
            var categories = db.Categories.ToList();
            List<string> listCategories = new List<string>();
            foreach (var category in categories)
            {
                listCategories.Add(category.category_name);
            }
            cbCategory.DataSource = listCategories;
            DisplayData();
        }

        private void DvgCoffee_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgCoffee.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dvgCoffee.SelectedRows[0];

                selectedItem = row.DataBoundItem as CoffeeOutput;
                txtName.Text = selectedItem.Name;
                txtPrice.Text = selectedItem.Price.ToString();
                cbCategory.Text = selectedItem.Category;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dvgCoffee.SelectedRows.Count != 0)
            {
                int coffeeIDSelect = int.Parse(this.dvgCoffee.SelectedRows[0].Cells[0].Value.ToString());
                Coffee updatedCoffee = db.Coffees.Where(x => x.id == coffeeIDSelect).FirstOrDefault();
                DataGridViewRow row = this.dvgCoffee.SelectedRows[0];
                var cate = db.Categories.Where(x => x.category_name == cbCategory.Text).FirstOrDefault();
                updatedCoffee.name = txtName.Text;
                updatedCoffee.price = double.Parse(txtPrice.Text);
                updatedCoffee.Category = cate;
                db.SubmitChanges();
                DisplayData();
            }
        }
        public void DisplayData()
        {
            var coffeeList = db.Coffees.ToList();
            dts.Clear();
            foreach (var coffee in coffeeList)
            {
                CoffeeOutput coffeeOutput = new CoffeeOutput
                {
                    Id = coffee.id,
                    Name = coffee.name,
                    Price = coffee.price,
                    Category = coffee.Category.category_name
                };
                dts.Add(coffeeOutput);
            }
            dvgCoffee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCoffee.SelectionChanged += DvgCoffee_SelectionChanged;

        }
    }
}
