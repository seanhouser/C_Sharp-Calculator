using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeProj
{
    public partial class Operand : UserControl
    {

        public Operand()
        {
            InitializeComponent();

            numOp.Maximum = int.MaxValue;
            numOp.Minimum = int.MinValue;

            lblOp.DoubleClick += flip;
        }

        private void flip(object sender, EventArgs e)
        {
            Value *= -1;
        }

        public int Value
        {
            get
            {
               return (int)numOp.Value;
            }
            set
            {
                numOp.Value = value;
            }
        }

        public string Text
        {
            get
            {
                return lblOp.Text;
            }
            set
            {
                lblOp.Text = value;
            }

        }

        
    }
}
