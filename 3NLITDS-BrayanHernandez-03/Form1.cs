using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLITDS_BrayanHernandez_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
         txtcelsius.Clear();
         txtfaren.Clear();
         txtkelvin.Clear();
         txtcelsius.Focus();
        }

        private void txtcelsius_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtfaren_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkelvin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
