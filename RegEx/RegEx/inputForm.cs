using System.Windows.Forms;

namespace RegEx
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            if(!InputValidation.IsValidName(txtName.Text))
            { 
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            }

            if(!InputValidation.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("The phone number is not a valid US phone number");
            }

            if(!InputValidation.IsValidMail(txtEmail.Text))
            {
                MessageBox.Show("The e-mail address is not valid.");
            }

            InputValidation.ReformatPhone(txtPhone.Text);
        }
    }
}
