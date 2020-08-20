using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InclusaoItens
{
    public partial class Form1 : Form
    {
        List<Item> lista = new ListaItem();
        public Form1()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var item = new Item();
            item.Produto = txtProduto.Text.ToString();
            item.Quantidade = Convert.ToDouble(txtQuantidade.Text.ToString());
            item.Preco = Convert.ToDouble(txtPreco.Text.ToString());
            item.TotalItem = item.Quantidade * item.Preco;
            lista.Add(item);
            //var newList = lista.Select(Item => new
            //{
            //Produto = item.Produto,
            //Quantidade = item.Quantidade,
            //Preco = item.Preco,
            //TotalItem = item.Quantidade * item.Preco
            //}).ToList();

            dgv.DataSource = null;
            dgv.DataSource = lista;
            dgv.Refresh();

            lblTotal.Text = "Total: " + CalcularTotal().ToString();

            txtPreco.Text = "";
            txtProduto.Text = "";
            txtQuantidade.Text = "";
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // foreach (var item in lista)
        //    // {
        //    //     MessageBox.Show("Produto: " + item.Produto + 
        //    //         "\n" + "Quantidade: " + item.Quantidade.ToString() +
        //    //         "\n" + "preço: " + item.Preco.ToString()
        //    //         ) ;
        //    // }
        //}
        private double CalcularTotal()
        {
            double total = 0.0;
            foreach (var item in lista)
            {
                total = total + (item.Quantidade * item.Preco);
            }
            return total;
        }
    }
}
