using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathServiceLibrary;
using CalcServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WinFormClient1
{
    public partial class Form1 : Form
    {
        private IMathService _channel = null;
        private ICalcService _channel2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var endpoint = new EndpointAddress("http://localhost:4444/MathService");
            _channel = ChannelFactory<IMathService>.CreateChannel(new BasicHttpBinding(), endpoint);

            var endpoint2 = new EndpointAddress("http://localhost:5555/CalcService");
            _channel2 = ChannelFactory<ICalcService>.CreateChannel(new BasicHttpBinding(), endpoint2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var myNum = new MathServiceLibrary.MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _channel.Add(myNum).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            var myNum = new MathServiceLibrary.MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _channel.Subtract(myNum).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            var myNum = new CalcServiceLibrary.MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _channel2.Multiply(myNum).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            var myNum = new CalcServiceLibrary.MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _channel2.Divide(myNum).ToString();
        }
    }
}
