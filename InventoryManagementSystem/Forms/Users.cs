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
    public partial class Users : Form
    {
        
        public Users()
        {
            InitializeComponent();
        }

        // method to update data
        private void UpdateDataGridView()
        {
            // list of users
            List<User> users = User.GetUsers();

            // clear dataGridView
            dgvUser.Rows.Clear();

            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];
                dgvUser.Rows.Add(user.id, user.username, user.name, user.role, user.password);
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // clear rows
            this.UpdateDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {   
                // if delete is clicked 
                if (e.ColumnIndex == this.colDelete.Index)
                {
                    // retrieve username on the row where click event happened
                    string toDeleteUsername = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();

                    // Delete confirmation
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete row data.", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // call method to delete user from databse
                        int deleteResponse = User.DeleteUser(toDeleteUsername);

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
                    string toEditUsername = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUser();
            addUserForm.ShowDialog();
            
            this.UpdateDataGridView();
            
            
            
        }
    }
}
