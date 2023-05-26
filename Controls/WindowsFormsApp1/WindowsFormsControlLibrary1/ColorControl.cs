using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class ColorControl: UserControl
    {
        public ColorControl()
        {
            InitializeComponent();
        }

        private void TextChanged(object sender, EventArgs e)
        {
            var color = Color.FromArgb(
                txtR.Value, txtG.Value, txtB.Value);

            lblColor.BackColor = color;
        }

        private void RdbDec_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDec.Checked)
            {
                txtR.NumberSystem = NumberSystems.Dec;
                txtG.NumberSystem = NumberSystems.Dec;
                txtB.NumberSystem = NumberSystems.Dec;
            }
        }

        private void RdbHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHex.Checked)
            {
                txtR.NumberSystem = NumberSystems.Hex;
                txtG.NumberSystem = NumberSystems.Hex;
                txtB.NumberSystem = NumberSystems.Hex;
            }
        }
    }
}
