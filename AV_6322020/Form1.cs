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
    public partial class formInterface2 : Form
    {
        public formInterface2()
        {
            InitializeComponent();
        }

        private void formInterface2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            TelaEletronico t2 = new TelaEletronico();
            t2.Show();
            this.Hide();
        }
    }
}
