using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV_6322020
{
    public partial class TelaEletronico : Form

    {
        public TelaEletronico()
        {
            InitializeComponent();
        }
        Preco p = new Preco();


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblPreco.Text = "Valor do Produto" + p.Calcular(int.Parse(txtPreco.Text)).ToString();
        }

        private void TelaEletronico_Load(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
  
        }
    }
}
