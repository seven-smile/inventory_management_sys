using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            int authenticatUser = User.AuthenticateUser(username, password);
            if (authenticatUser == 1)
            {
                Form main = new MainWindow();
                main.Show();
            }
            //this.Close();

            //Form main = new MainWindow();
            //main.Show();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
