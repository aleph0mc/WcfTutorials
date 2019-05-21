using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wref = WinFormClient1.MathServiceReference;

namespace WinFormClient1
{
    public partial class Form1 : Form
    {
        private wref.MathServiceClient _proxy = null;

        public Form1()
        {
            InitializeComponent();
            _proxy = new wref.MathServiceClient("MathService_NetTcp");

        }

        private void btnNtAdd_Click(object sender, EventArgs e)
        {
            var myNum = new wref.MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _proxy.Add(myNum).ToString();
        }

        private void btnNtSubtract_Click(object sender, EventArgs e)
        {
            var myNum = new wref.MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _proxy.Subtract(myNum).ToString();
        }
    }
}
