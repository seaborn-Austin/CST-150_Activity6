using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity6
{
    public partial class wtFrm : Form
    {
        public wtFrm()
        {
            InitializeComponent();
        }

        private void wtBtn_Click(object sender, EventArgs e)
        {
            double wtPounds = double.Parse(wtLbTxt.Text);
            double wtKg = wtPounds * 0.45359237;
            double result = Math.Round((Double)wtKg, 3);
            wtKgTxt.Text = result.ToString();
        }
    }
}
