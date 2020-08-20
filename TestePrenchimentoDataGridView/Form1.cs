using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePrenchimentoDataGridView
{
    public partial class Form1 : Form
    {

        public List<Pessoa> lsPessoa ;
        public Form1()
        {
            InitializeComponent();
            lsPessoa = new List<Pessoa>(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsPessoa.Add(null);

            var novaList = lsPessoa.Select(pessoa => new
            {
                nome = "Liasdasdas"
            }).ToList();   
            dataGridView1.DataSource = novaList;

            dataGridView1.Refresh();
        }

     /*   private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        */
    }
}
