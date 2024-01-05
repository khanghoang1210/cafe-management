using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Home : Form
    {
        CoffeeDBDataContext db = new CoffeeDBDataContext();
        BindingSource dts = new BindingSource();
        CoffeeOutput selectedItem = new CoffeeOutput();
        public Home()
        {
            InitializeComponent();

            dvgCoffee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgCoffee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dvgCoffee.AllowUserToOrderColumns = true;
            dvgCoffee.AllowUserToResizeColumns = true;
            dvgCoffee.ReadOnly = true;
            dvgCoffee.DataSource = dts;
            DisplayData();
            //var categories = db.Categories.ToList();
            //List<string> listCategories = new List<string>();
            //foreach (var category in categories)
            //{
            //    listCategories.Add(category.category_name);
            //}
            //cbCategory.DataSource = listCategories;
        }

        //private void DvgCoffee_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dvgCoffee.SelectedRows.Count != 0)
        //    {
        //        DataGridViewRow row = this.dvgCoffee.SelectedRows[0];

        //        selectedItem = row.DataBoundItem as CoffeeOutput;
        //        txtName.Text = selectedItem.Name;
        //        txtPrice.Text = selectedItem.Price.ToString();
        //        cbCategory.Text = selectedItem.Category;
        //    }
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (dvgCoffee.SelectedRows.Count != 0)
        //    {
        //        int coffeeIDSelect = int.Parse(this.dvgCoffee.SelectedRows[0].Cells[0].Value.ToString());
        //        Coffee updatedCoffee = db.Coffees.Where(x => x.id == coffeeIDSelect).FirstOrDefault();
        //        DataGridViewRow row = this.dvgCoffee.SelectedRows[0];
        //        var cate = db.Categories.Where(x => x.category_name == cbCategory.Text).FirstOrDefault();
        //        updatedCoffee.name = txtName.Text;
        //        updatedCoffee.price = double.Parse(txtPrice.Text);
        //        updatedCoffee.Category = cate;
        //        db.SubmitChanges();
        //        DisplayData();
        //        MessageBox.Show("Update successful.", "Coffee", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.Close();
        //    }
        //}
        public void DisplayData()
        {
            dts.Clear();
            var coffeeList = db.Coffees.ToList();

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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Coffee item = new Coffee();
            AddForm.coffee = item;
            AddForm.isEdit = false;
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            DisplayData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dvgCoffee.SelectedRows.Count != 0)
            {
                AddForm.isEdit = true;
                int coffeeIDSelect = int.Parse(this.dvgCoffee.SelectedRows[0].Cells[0].Value.ToString());
                Coffee updatedCoffee = db.Coffees.Where(x => x.id == coffeeIDSelect).FirstOrDefault();
                DataGridViewRow row = this.dvgCoffee.SelectedRows[0];
                AddForm.selectedItem = (CoffeeOutput)row.DataBoundItem;

                AddForm addForm = new AddForm();

                addForm.ShowDialog();
                updatedCoffee = AddForm.coffee;
                //updatedCoffee.name = AddForm.coffee.name;
                //updatedCoffee.price = AddForm.coffee.price;
                //updatedCoffee.Category.category_name = AddForm.coffee.Category.category_name;
                //updatedCoffee.Category.id = AddForm.coffee.Category.id;
                //db.Coffees.InsertOnSubmit(updatedCoffee);
                db.SubmitChanges();
                DisplayData();
                //MessageBox.Show("Update successful.", "Coffee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }

        }
    }
}
