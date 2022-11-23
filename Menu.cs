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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TStore
{
    public partial class Menu : Form
    {
        private User CurrentUser;

        private Database database;
        public Menu(string userName)
        {
            InitializeComponent();
            this.database = Repository.Deserialize();
            this.CurrentUser = database.GetUserIfExists(userName);
            this.usernameLabel.Text = userName;
            this.balanceLabel.Text = CurrentUser.GetBalance().ToString();
            this.FormClosing += new FormClosingEventHandler(this.Menu_Closing);
        }

        public new void Update()
        {
            this.usernameLabel.Text = CurrentUser.GetUserName();
            this.balanceLabel.Text = CurrentUser.GetBalance().ToString();
        }

        private void Menu_Closing(object sender, EventArgs e)
        {
            Repository.Serialize(this.database);
        }

        private void replenishButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentUser.ReplenishBalance(Double.Parse(amount.Text));
                balanceLabel.Text = CurrentUser.GetBalance().ToString();
            } catch (Exception)
            {
                MessageBox.Show("Amount is not valid");
            }
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            new ProductsList(CurrentUser.GetHistory(), CurrentUser, this).Show();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            new ProductsList(database.GetProducts(), CurrentUser, this).Show();

        }

        
    }
}
