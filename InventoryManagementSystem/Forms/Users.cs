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
        // get the list of users
        List<User> users = User.GetUsers();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // clear rows
            dgvUser.Rows.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];
                dgvUser.Rows.Add(user.id, user.username, user.name, user.role, user.password);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
