using System.Windows.Forms;

namespace regular_expressions
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!InputChecker.IsValidName(txtName.Text))
            {
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            }

            if (!InputChecker.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("The phone number is not a valid US phone number");
            }

            if (!InputChecker.IsValidMail(txtEmail.Text))
            {
                MessageBox.Show("The e-mail address is not valid.");
            }

            InputChecker.ReformatPhone(txtPhone.Text);
        }
    }
}
