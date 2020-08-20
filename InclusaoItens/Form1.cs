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

            foreach (var item in ListaProdutos())
            {

                cbProduto.Items.Add(item.Nome);
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var item = new Item();
            item.Produto = cbProduto.Text.ToString();
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
            cbProduto.Text = "";
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

        public List<Produto> ListaProdutos()
        {
            var listaProduto = new List<Produto>();
            var p1 = new Produto();
            var p2 = new Produto();
            var p3 = new Produto();
            var p4 = new Produto();
            var p5 = new Produto();

            p1.Nome = "Mala sem alça";
            p2.Nome = "Sogra em casa";
            p3.Nome = "Cunhado comilão";
            p4.Nome = "Filhos chorões";
            p5.Nome = "Stress pelos filmes";


            listaProduto.Add(p1);
            listaProduto.Add(p2);
            listaProduto.Add(p3);
            listaProduto.Add(p4);
            listaProduto.Add(p5);

            return listaProduto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( cbProduto.Text.ToString());
        }
    }
}
