using System;
using System.Windows.Forms;

namespace EscolaProMontijo
{
    public partial class Create_a_signature : Form
    {
        public Create_a_signature()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxSignature.Text) || string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text)) // Checking if all textboxes are filled
                {
                    MessageBox.Show("You have to fill everything !");
                    
                }
                else
                {
                    connectionMySql connectionDB = new connectionMySql();

                    connectionDB.createNewSignature(textBoxName.Text, textBoxEmail.Text, textBoxSignature.Text);  // create the new signature with infos in textboxes
                    MessageBox.Show("New signature added !");
                    textBoxEmail.Text = null;
                    textBoxName.Text = null;
                    textBoxSignature.Text = null;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void Create_a_signature_Load(object sender, EventArgs e)
        {

        }
    }
}
