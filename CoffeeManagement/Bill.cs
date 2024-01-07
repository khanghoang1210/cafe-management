using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Bill : Form
    {
        List<String> listItem = new List<string>();
        List<String> listQty = new List<string>();
        List<String> listPrice = new List<string>();
        string amount = "";
        public Bill(List<string> listItem, List<string> listQty, List<string> listPrice, string amount)
        {
            InitializeComponent();
            this.listItem = listItem;
            this.listQty = listQty;
            this.listPrice = listPrice;
            this.amount = amount;
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(panelBill.Width, panelBill.Height);
            panelBill.DrawToBitmap(bmp, new Rectangle(0, 0, panelBill.Width, panelBill.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            foreach (var item in listItem)
            {
                listBox1.Items.Add(item);
            }

            foreach (var item in listQty)
            {
                listBox2.Items.Add(item);
            }

            foreach (var item in listPrice)
            {
                listBox3.Items.Add(item);
            }
            priceTxt.Text = amount;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;

            PrintDialog dlg = new PrintDialog();
            dlg.Document = doc;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
    }
}
