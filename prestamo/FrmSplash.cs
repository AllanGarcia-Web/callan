using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perloan_Desktop
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            //this.Visible = false;
            //timer1();
            FrmInicio inicio = new FrmInicio();
            inicio.instance.Show();
            
            //new FrmInicio().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
