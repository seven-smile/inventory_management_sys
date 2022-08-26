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
    public partial class ProductsUpdate : Form
    {
        private int id;
        private string name;
        private string code;
        private int quantity;
        private float cost;
        private float retail;
        private int reorder;
        private string category;

        public ProductsUpdate(int id, string name, string code, int quantity, float cost, float retail, int reorder, string category)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.code = code;
            this.quantity = quantity;
            this.cost = cost;
            this.retail = retail;
            this.reorder = reorder;
            this.category = category;
        }

        private void ProductsUpdate_Load(object sender, EventArgs e)
        {
            // load existing data into the textfields
            textBoxName.Text = name;
            textBoxCode.Text = code;
            numericQuantity.Value = quantity;
            numericCost.Value = (decimal) cost;
            numericRetail.Value = (decimal) retail;
            numericReorder.Value = reorder;
            comboBoxCategory.Text = category;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get all data in the textboxes
            string name = textBoxName.Text;
            string code = textBoxCode.Text;
            int quantity = Convert.ToInt32(numericQuantity.Value);
            float cost = (float)numericCost.Value;
            float retail = (float)numericRetail.Value;
            int reorder = Convert.ToInt32(numericReorder.Value);
            string category = comboBoxCategory.Text;

            // if-else logic to handle validatation
            if (name.Length <= 0 | category.Length <= 0 | quantity <= 0 | cost <= 0.00 | retail <= 0.00 | code.Length <= 0)
            {

                lblError.Text = "Please Input valid data in the fields";
                lblError.Visible = true;
                return;
            }

            // get the int equivalent of the category string
            Dictionary<string, int> categories_dict = Category.GetCategoryIds();
            int cat_id = categories_dict[category];


            // Call the AddUser method to insert a new user into the database.
            int updateProduct = Product.UpdateProduct(id, name, code, quantity, cost, retail, reorder, cat_id);

            // if successful, close form.
            if (updateProduct == 1) this.Close();
        }
    }
}
