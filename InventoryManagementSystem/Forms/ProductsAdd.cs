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
    public partial class ProductsAdd : Form
    {
        Dictionary<string, int> categories_dict = Category.GetCategoryIds();
        public ProductsAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get all data in the textboxes
            string name = textBoxName.Text;
            string code = textBoxCode.Text;
            int quantity = Convert.ToInt32(numericQuantity.Value);
            float cost = (float) numericCost.Value;
            float retail = (float) numericRetail.Value;
            int reorder = Convert.ToInt32(numericReorder.Value);
            string category = comboBoxCategory.Text;

            // if-else logic to handle validatation
            if (name.Length <= 0 | category.Length <=0 | quantity <= 0 | cost <= 0.00 | retail <= 0.00 | code.Length <= 0)
            {

                lblError.Text = "Please Input valid data in the fields";
                lblError.Visible = true;
                return;
            }

            // get the int equivalent of the category string
            int cat_id = categories_dict[category];
            

            // Call the AddUser method to insert a new user into the database.
            int createProduct = Product.AddProduct(name, code, quantity, cost, retail, reorder, cat_id);

            // if successful, close form.
            if (createProduct == 1) this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clearing all fields
            textBoxName.Clear();
            textBoxCode.Clear();
            numericQuantity.Value = 0;
            numericCost.Value = 0;  
            numericRetail.Value = 0;
            numericReorder.Value = 0;
            comboBoxCategory.Text = "";
        }

        private void ProductsAdd_Load(object sender, EventArgs e)
        {
            
            // add categories to combo box
            for (int i = 0; i < categories_dict.Count; i++)
            {
                comboBoxCategory.Items.Add(categories_dict.Keys.ElementAt(i).ToString());
            }
            
        }
    }
}
