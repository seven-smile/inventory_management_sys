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
    public partial class Sales : Form
    {
        List<Product> products = Product.GetProducts();
        public Sales()
        {
            InitializeComponent();
        }

        private void UpdateDataGridView()
        {
            // list of users
            List<Sale> sales = Sale.GetSales();

            // clear dataGridView
            dgvSales.Rows.Clear();

            for (int i = 0; i < sales.Count; i++)
            {
                Sale sale = sales[i];
                string sale_prod_name = "";

                for (int j = 0; j < products.Count; j++)
                {
                    Product product = products[j];
                    if(product.code == sale.product_code)
                    {
                        sale_prod_name = product.name;
                        break;
                    }
                }
                dgvSales.Rows.Add(sale.id, sale_prod_name, sale.quantity, sale.date.ToString());
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // load table data
            this.UpdateDataGridView();
        }
    }
}
