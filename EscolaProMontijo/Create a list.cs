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
    public partial class Create_a_list : Form
    {
        connectionMySql connectionDB = new connectionMySql();

        public Create_a_list()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxListsName.Text != "")
                {
                    connectionDB.createNewList(textBoxListsName.Text, textBoxColumn1.Text, textBoxColumn2.Text, textBoxColumn3.Text, textBoxColumn4.Text, textBoxColumn5.Text, textBoxColumn6.Text);
                    var result = MessageBox.Show("Do you want to modify the list now ?", "List created successfully", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        ViewList vList = new ViewList();
                        vList.ShowDialog();
                    }
                    if (result == DialogResult.No)
                    {
                        var result2 = MessageBox.Show("Do you want to create a new list ?", "", MessageBoxButtons.YesNo);

                        if (result2 == DialogResult.No)
                        {
                            this.Close();
                        }
                        else
                        {
                            this.Controls.Clear();
                            this.InitializeComponent();
                            Create_a_list_Load(null, null);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a list's name");
                }
            }
            catch
            {
                MessageBox.Show("Error, would you like to retry ?", "captiontry", MessageBoxButtons.RetryCancel);
            }
        }

        private void Create_a_list_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 16; i++)
            {
                comboBoxNbColumn.Items.Add(i);
            }
        }

        private void comboBoxNbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int j = 1; j < 16; j++)
            {
                TextBox tB = (TextBox)this.Controls.Find("textBoxColumn" + j, true)[0];
                tB.Visible = false;

                Label lb = (Label)this.Controls.Find("labelColumn" + j, true)[0];
                lb.Visible = false;
            }

            for ( int i =1; i < Convert.ToInt16(comboBoxNbColumn.Text)+1; i++)
            {
                TextBox tB = (TextBox)this.Controls.Find("textBoxColumn"+i, true)[0];
                tB.Visible = true;

                Label lb = (Label)this.Controls.Find("labelColumn" + i, true)[0];
                lb.Visible = true;
            }
        }
    }
}
