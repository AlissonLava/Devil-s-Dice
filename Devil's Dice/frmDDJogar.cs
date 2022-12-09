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
    public partial class frmDDJogar : Form
    {
        List<string> Almas = new List<string> { };
        int intRoll = 666;
        int intAlmaAtual=0;
        public frmDDJogar(List<string> ListaAlmas)
        {
            InitializeComponent();

            Almas = ListaAlmas;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            this.lblAlmaAtual.Text = Almas[intAlmaAtual];
            this.lblRollAnterior.Text = "Roll Anterior: " + intRoll;

            Roll();

            intAlmaAtual ++;
            if(Almas.Count > intAlmaAtual)
            {
                intAlmaAtual = 0;
            }

            if (Almas.Count == 1)
            {
                //PREMIO
            }
        }

        private void Roll()
        {
            Timer tmr = new Timer(); //   timer/animação
            
            for (int i = 1; i < 10+(666-intRoll); i++)
            {
                for (int j = 1; j < intRoll; j++)
                {
                    this.lblRoll.Text = j.ToString();
                    tmr.Interval = 100;
                    tmr.Start();
                }
            }

            Random rnd = new Random();
            intRoll = rnd.Next(1, intRoll);

            this.lblRoll.Text = intRoll.ToString();
            
            if (intRoll ==1) {
                Almas.Remove(this.lblAlmaAtual.Text);
            }
        }






    }
}
