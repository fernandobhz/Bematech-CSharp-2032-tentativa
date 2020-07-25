using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bematech_CSharp_2032_tentativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iRetorno;
            iRetorno = MP2032.IniciaPorta("COM1");
            iRetorno = MP2032.FormataTX("Bematech – BSP", 2, 0, 0, 1, 1);
            iRetorno = MP2032.FechaPorta();
            MessageBox.Show("OK");
        }
    }
}
