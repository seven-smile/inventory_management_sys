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
    public partial class UpdateUser : Form
    {
        // username of User to delete
        private string id;
        private string username;
        private string name;
        private string role;
        private string password;
        
        public UpdateUser()
        {
            InitializeComponent();
        }
        public UpdateUser(string id, string username, string name, string role, string password)
        {
            InitializeComponent();
            this.id = id;
            this.username = username;
            this.name = name;   
            this.role = role;   
            this.password = password;
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            // load existing data into the textfields
            textBoxUsername.Text = username;
            textBoxName.Text = name;
            comboBoxRole.Text = role;
            textBoxPassword1.Text = password;
            textBoxPassword2.Text = password;

            // disable username field
            textBoxUsername.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get all current(updated) data in the textboxes
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
            }
            else if (username.Length <= 0 | name.Length <= 0 | password.Length <= 0)
            {

                lblError.Text = "Please Fill in all fields";
                lblError.Visible = true;
                return;
            }

            // Call the UpdateUser method to insert a new user into the database.
            int updateUser = User.UpdateUser(int.Parse(id), username, name, role, password);

            // if successful, close form.
            if (updateUser == 1) this.Close();
        }
    }
}
