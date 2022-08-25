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
    public partial class CategoryUpdate : Form
    {
        private string id;
        private string name;
        public CategoryUpdate(string id, string name)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CategoryUpdate_Load(object sender, EventArgs e)
        {
            // load existing data into the textfields
            textBoxName.Text = name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // get the current name in the textBox field
            string name = textBoxName.Text;
            

            // if-else logic to handle validatation
           if (name.Length <= 0)
            {
                lblError.Text = "Please Fill in all fields";
                lblError.Visible = true;
                return;
            }

            // Call the UpdateUser method to insert a new user into the database.
            int updateCategory = Category.UpdateCategory(int.Parse(id), name);

            // if successful, close form.
            if (updateCategory == 1) this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
        }
    }
}
