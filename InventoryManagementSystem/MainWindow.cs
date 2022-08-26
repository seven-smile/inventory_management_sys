namespace InventoryManagementSystem
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Users";
            openChildForm(new Forms.Users());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Categories";
            openChildForm(new Forms.Categories());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Products";
            openChildForm(new Forms.Products());
        }
    }
}