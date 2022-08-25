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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void UpdateDataGridView()
        {
            // list of users
            List<Category> categories = Category.GetCategories();

            // clear dataGridView
            dgvCategory.Rows.Clear();

            for (int i = 0; i < categories.Count; i++)
            {
                Category cat = categories[i];
                dgvCategory.Rows.Add(cat.id, cat.name);
            }
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // load table data
            this.UpdateDataGridView();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var addCategoryForm = new CategoryAdd();
            addCategoryForm.ShowDialog();

            this.UpdateDataGridView();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                // if delete is clicked 
                if (e.ColumnIndex == this.colDelete_.Index)
                {
                    // retrieve username on the row where click event happened
                    string toDeleteCat = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();

                    // Delete confirmation
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete row data.", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // call method to delete user from databse
                        int deleteResponse = Category.DeleteCategory(toDeleteCat);

                        // if delete action is successful, refresh dataGridView.
                        if (deleteResponse == 1) this.UpdateDataGridView();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }


                }
                // if edit is clicked
                else if (e.ColumnIndex == this.colEdit_.Index)
                {
                    // retrieve username on the row where click event happened
                    string toEditId = dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string toEditCatName = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                    

                    // open the updateUser Form
                    var updateUserForm = new CategoryUpdate(toEditId, toEditCatName);
                    updateUserForm.ShowDialog();

                    this.UpdateDataGridView();

                }
            }
        }
    }
}
