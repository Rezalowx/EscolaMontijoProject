using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if (string.IsNullOrWhiteSpace(textBoxSignature.Text) || string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    MessageBox.Show("You have to fill everything !");
                    
                }
                else
                {
                    connectionMySql connectionDB = new connectionMySql();

                    connectionDB.createNewSignature(textBoxName.Text, textBoxEmail.Text, textBoxSignature.Text);
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
    }
}
