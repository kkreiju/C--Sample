namespace hello_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void idKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (idNumberField.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Username u = new Username();
            u.setId(int.Parse(idNumberField.Text));
            if(u.getId() == 12345678 && passTextField.Text == "Wakanda123!")
            {
                MessageBox.Show("Log In Successful", "UC Banilad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Log In Failed", "UC Banilad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
