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
            connectionDB.createNewList(textBoxListsName.Text, textBoxColumn1.Text, textBoxColumn2.Text, textBoxColumn3.Text, textBoxColumn4.Text, textBoxColumn5.Text, textBoxColumn6.Text);
        }
    }
}
