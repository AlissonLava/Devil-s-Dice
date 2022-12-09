using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devil_s_Dice
{
    
    public partial class frmDDMain : Form
    {
        List<string> lstAlmas = new List<string> {};

        public frmDDMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstAlmas.Clear();
            this.lblAlmas.Text = "";
            this.txtAlma.Text = "";

            this.btnJogar.Enabled = false;
        }

        private void btnAddAlma_Click(object sender, EventArgs e)
        {
            lstAlmas.Add( this.txtAlma.Text);

            this.lblAlmas.Text = this.lblAlmas.Text + this.txtAlma.Text + "   ";
            this.txtAlma.Text = "";

            if (this.lstAlmas.Count > 1)
            {
                this.btnJogar.Enabled=true;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            frmDDJogar DDJogar = new frmDDJogar(lstAlmas);
            DDJogar.Show();
        }
    }
}
