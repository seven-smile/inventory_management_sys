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
    public partial class CategoryAdd : Form
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }


        private void CategoryAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get all data in the textboxes
            string name = textBoxName.Text;


            // if-else logic to handle validatation
            if (name.Length <= 0)
            {
                lblError.Text = "Please fill in the blank fields";
                lblError.Visible = true;
                return;
            }

            // Call the AddUser method to insert a new user into the database.
            int createCategory = Category.AddCategory(name);

            // if successful, close form.
            if (createCategory == 1) this.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
        }
    }
 }

