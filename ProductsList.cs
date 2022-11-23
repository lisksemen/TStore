using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TStore
{
    public partial class ProductsList : Form
    {
        private List<Product> Products;

        private User CurrentUser;

        private Menu Menu;

        private const int ProductHeight = 100;

        private const int ProductWidth = 200;

        private const int ProductComponentWidth = ProductWidth;

        private const int ProductComponentHeight = ProductHeight / 2;

        public ProductsList(List<Product> products, User currentUser, Menu menu)
        {
            this.Width = 800;
            this.Height = 500;
            this.Products = new(products);
            this.Menu = menu;
            ShowProducts(Products);
            CurrentUser = currentUser;
            InitializeComponent();
        }

        private void ShowProducts(List<Product> products)
        {
            int x = 0;
            int y = 0;

            foreach (Product product in products)
            {
                if (x + ProductWidth > this.Width)
                {
                    Debug.WriteLine(x + " + " + ProductWidth);
                    Debug.WriteLine(this.Width);
                    x = 0;
                    y += ProductHeight;
                }
                ShowProduct(product, x, y);
                x += ProductWidth;
            }
        }

        private void ShowProduct(Product product, int x, int y)
        {

            AddProductParams(x, y, product.Name, product.Price);
            AddBuyButton(x, y, product);
            
        }

        private void AddBuyButton(int x, int y, Product product)
        {
            Button button = new()
            {
                Location = new Point(x, y + ProductComponentHeight),
                Text = "Buy",
                Width = ProductComponentWidth,
                Height = ProductComponentHeight
            };
            button.Click += (object sender, EventArgs e) =>
            {
                BuyIfPossible(product);
            };
            this.Controls.Add(button);
            button.Show();
        }

        private void BuyIfPossible(Product product)
        {
            if (CurrentUser.GetBalance() < product.Price)
            {
                MessageBox.Show("Not enough money to buy " + product.Name);
                return;
            }
            CurrentUser.Buy(product);
            Menu.Update();
        }

        private void Buy(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddProductParams(int x, int y, string name, double price)
        {
            Label label = new()
            {
                Location = new Point(x, y),

                Text = name + "\nPrice - " + price,
                Width = ProductComponentWidth,
                Height = ProductComponentHeight
            };
            this.Controls.Add(label);
            label.Show();
        }

        
    }
}
