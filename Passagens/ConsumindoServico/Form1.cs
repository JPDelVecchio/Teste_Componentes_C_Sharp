using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumindoServico.ServiceReference1;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String cpf = txtCPF.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente clientecadastro = new Cliente();
                clientecadastro.Nome = nome;
                clientecadastro.Cpf = cpf;

                servico.Add(clientecadastro);
                MessageBox.Show("Cliente Cadastrado com sucesso!!!!");
            }
            catch (Exception ex)
            {
                //salvaria um log

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente resultado = servico.Buscar(nome);
                txtCPF.Text = resultado.Cpf;
            }
            catch (Exception ex)  
            {
                // salva um log 
            }
        }
    }
}
