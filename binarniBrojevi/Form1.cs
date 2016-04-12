using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binarniBrojevi
{
    public partial class Form1 : Form
    {
        Brojevi brojevi;

        public Form1()
        {
            InitializeComponent();
            brojevi = new Brojevi();
            osvjezi();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            brojevi.binarni = txtB1.Text;
            brojevi.decimalni = brojevi.BinToDec(txtB1.Text);



            brojevi.listaBrojeva.Add(new Brojevi() { binarni = brojevi.binarni, decimalni = brojevi.decimalni });
            osvjezi();
       

        }

        public void osvjezi() 
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = brojevi.listaBrojeva;
            dataGridView1.Refresh();
        }

    }
}
