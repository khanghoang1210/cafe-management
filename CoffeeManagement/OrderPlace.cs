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
    public partial class OrderPlace : Form
    {
        public static CoffeeOutput selectedItem;
        private readonly CoffeeDBDataContext db = new CoffeeDBDataContext();
        public OrderPlace()
        {
            InitializeComponent();
            User user = Login.currentUser;

            var categories = db.Categories.ToList();
            List<string> listCategories = new List<string>();

            foreach (var category in categories)
            {
                listCategories.Add(category.category_name);
            }

            cbCategory.DataSource = listCategories;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbCategory.Text))
            {
                lstItem.Items.Clear();
                Category cate = db.Categories.Where(x => x.category_name == cbCategory.Text).FirstOrDefault();
                List<Coffee> coffeeList = db.Coffees.Where(x => x.category_id == cate.id).ToList();

                foreach (var coffee in coffeeList)
                {
                    lstItem.Items.Add(coffee.name);
                    lstItem.Items.Add("");
                }
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text))
            {
                lstItem.Items.Clear();
                Category cate = db.Categories.Where(x => x.category_name == cbCategory.Text).FirstOrDefault();
                List<Coffee> coffeeList = db.Coffees.Where(x => x.name.Contains(txtSearch.Text)).ToList();

                foreach (var coffee in coffeeList)
                {
                    lstItem.Items.Add(coffee.name);
                    lstItem.Items.Add("");
                }
            }

        }

        private void OrderPlace_Load(object sender, EventArgs e)
        {
            lstItem.Items.Clear();
            cbCategory.SelectedItem = null;
            cbCategory.SelectedText = "--select--";
        }

        private void lstItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuan.ResetText();
            txtTotal.Clear();
            if (lstItem.SelectedItems.Count == 0)
                return;
            string selectedItem = lstItem.SelectedItems[0].Text;


            Coffee selectedCoffee = db.Coffees.Where(x => x.name == selectedItem).FirstOrDefault();
            txtItem.Text = selectedItem;
            txtPrice.Text = selectedCoffee.price.ToString();
            txtQuan.Text = "1";
            txtTotal.Text = selectedCoffee.price.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtQuan.Text = (int.Parse(txtQuan.Text) + 1).ToString();
            txtTotal.Text = (double.Parse(txtPrice.Text) * double.Parse(txtQuan.Text)).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtQuan.Text) >= 1)
                txtQuan.Text = (int.Parse(txtQuan.Text) - 1).ToString();
            txtTotal.Text = (double.Parse(txtPrice.Text) * double.Parse(txtQuan.Text)).ToString();
        }

        protected int n, total = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            n = dgvCart.Rows.Add();
            dgvCart.Rows[n].Cells[0].Value = txtItem.Text;
            dgvCart.Rows[n].Cells[1].Value = txtPrice.Text;
            dgvCart.Rows[n].Cells[2].Value = txtQuan.Text;
            dgvCart.Rows[n].Cells[3].Value = txtTotal.Text;
        }
    }
}
