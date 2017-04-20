using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeProj
{
    public partial class frmMain : Form
    {
        static object SyncRoot = new object();

        public frmMain()
        {
            InitializeComponent();

            opr1.Text = "Operand 1";
            opr2.Text = "Operand 2";

            btnAdd.Click += calculate;
            btnSubtract.Click += calculate;
            btnMultiply.Click += calculate;
            btnDivide.Click += calculate;
            btnModulo.Click += calculate;
            
        }

        private void calculate(object sender, EventArgs e)
        {
            int result = 0;

            if (sender == btnAdd)
            {
                result = opr1.Value + opr2.Value;
            }
            else if (sender == btnSubtract)
            {
                result = opr1.Value - opr2.Value;
            }
            else if (sender == btnMultiply)
            {
                result = opr1.Value * opr2.Value;
            }
            else if (sender == btnDivide)
            {
                result = opr1.Value / opr2.Value;
            }
            else if (sender == btnModulo) 
            {
                result = opr1.Value % opr2.Value;
            }

            rtbResult.Text = result.ToString();
        }

        private void opr1_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

    }
}
