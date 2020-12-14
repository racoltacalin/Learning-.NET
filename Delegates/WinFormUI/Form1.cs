using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        ShoppingCartModel cart = new ShoppingCartModel();

        public Form1()
        {
            InitializeComponent();
            PopulateCartWithDemoData();
        }

        private void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.513M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.843M });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal(SubTotalAlert, CalculateLevelDiscount, PrintOutDiscountAlert);

            MessageBox.Show($"The total is {total:C2}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal((subTotal) => SubTotalTextBox.Text = $"{subTotal:C2}",
                (products, subTotal) => subTotal - (products.Count * 2),
                (message) => { });

            TotalTextBox.Text = $"{total:C2}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrintOutDiscountAlert(string message)
        {
            MessageBox.Show(message);
        }

        private void SubTotalAlert(decimal subTotal)
        {
            MessageBox.Show($"The subtotal is {subTotal:C2}");
        }

        private decimal CalculateLevelDiscount(List<ProductModel> products, decimal subTotal)
        {
            return subTotal - products.Count();
        }
    }
}
