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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        // method to update data
        private void UpdateDataGridView()
        {
            // list of users
            List<Product> products = Product.GetProducts();

            // clear dataGridView
            dgvProduct.Rows.Clear();

            // get the dictionary of categories
            Dictionary<int, string> categories_dict = Category.GetCategoryNames();
            

            for (int i = 0; i < products.Count; i++)
            {
                Product product = products[i];

                //
                string cat_string = categories_dict[product.category];
                dgvProduct.Rows.Add(product.id, product.name, product.code, product.quantity, product.cost_price, product.retail_price, product.reorder_level, cat_string);
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // load table data
            this.UpdateDataGridView();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addProductForm = new ProductsAdd();
            addProductForm.ShowDialog();

            this.UpdateDataGridView();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                // if delete is clicked 
                if (e.ColumnIndex == this.colDelete.Index)
                {
                    // retrieve id on the row where click event happened
   
                    int toDeleteProdID = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString());

                    // Delete confirmation
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete row data.", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // call method to delete user from databse
                        int deleteResponse = Product.DeleteProduct(toDeleteProdID);

                        // if delete action is successful, refresh dataGridView.
                        if (deleteResponse == 1) this.UpdateDataGridView();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }


                }
                // if edit is clicked
                else if (e.ColumnIndex == this.colEdit.Index)
                {
                    // retrieve username on the row where click event happened
                    int toEditId = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString()); ;
                    string toEditName = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string toEditCode = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                    int toEditQuantity = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
                    float toEditCost = (float) dgvProduct.Rows[e.RowIndex].Cells[4].Value;
                    float toEditRetail = (float) dgvProduct.Rows[e.RowIndex].Cells[5].Value;
                    int toEditReorder = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString());
                    string toEditCategory = dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString();


                    // open the updateUser Form
                    var updateUserForm = new ProductsUpdate(toEditId, toEditName, toEditCode, toEditQuantity, toEditCost, toEditRetail, toEditReorder, toEditCategory);
                    updateUserForm.ShowDialog();

                    this.UpdateDataGridView();

                }
            }
        }
    }
}
