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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clearing all fields
            textBoxUsername.Clear();
            textBoxName.Clear();
            comboBoxRole.Text = "";
            textBoxPassword1.Clear();
            textBoxPassword2.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get all data in the textboxes
            string username = textBoxUsername.Text;
            string password = textBoxPassword1.Text;
            string name = textBoxName.Text;
            string password2 = textBoxPassword2.Text;
            string role = comboBoxRole.Text;

            // if-else logic to handle validatation
            if (password != password2)
            {
                lblError.Text = "Password Mismatch";
                lblError.Visible = true;
                return;
            } else if (username.Length <= 0 | name.Length <= 0 | password.Length <= 0) {
                
                lblError.Text = "Please Fill in all fields";
                lblError.Visible = true;
                return;
            }

            // Call the AddUser method to insert a new user into the database.
            int createUser = User.AddUser(username, name, role, password);

            // if successful, close form.
            if (createUser == 1) this.Close();

        }
    }
}
