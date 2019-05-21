using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wref = WinFormsClient.WASMathServiceRef;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        private wref.MathServiceClient _client = null;

        public Form1()
        {
            InitializeComponent();
            _client = new wref.MathServiceClient("NetTcpBinding_IMathService");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumber1.Text);
            int num2 = int.Parse(txtNumber2.Text);

            var myNum = new wref.MyNumbers
            {
                Number1 = num1,
                Number2 = num2
            };

            var res = _client.Add(myNum);
            txtResult.Text = res.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumber1.Text);
            int num2 = int.Parse(txtNumber2.Text);

            var myNum = new wref.MyNumbers
            {
                Number1 = num1,
                Number2 = num2
            };

            var res = _client.Subtract(myNum);
            txtResult.Text = res.ToString();
        }
    }
}
