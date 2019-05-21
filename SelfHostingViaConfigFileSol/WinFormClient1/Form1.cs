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
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WinFormClient1
{
    public partial class Form1 : Form
    {
        private IMathService _basicHttpChannel = null;
        private IMathService _wsHttpChannel = null;
        private IMathService _netTcpChannel = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _basicHttpChannel = new ChannelFactory<MathServiceLibrary.IMathService>("MathService_BasicHttp").CreateChannel();

            _wsHttpChannel = new ChannelFactory<MathServiceLibrary.IMathService>("MathService_WsHttp").CreateChannel();

            _netTcpChannel = new ChannelFactory<MathServiceLibrary.IMathService>("MathService_NetTcp").CreateChannel();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var myNum = new MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _basicHttpChannel.Add(myNum).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            var myNum = new MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _basicHttpChannel.Subtract(myNum).ToString();
        }

        private void btnWsAdd_Click(object sender, EventArgs e)
        {
            var myNum = new MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _wsHttpChannel.Add(myNum).ToString();
        }

        private void btnWsSubtract_Click(object sender, EventArgs e)
        {
            var myNum = new MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _wsHttpChannel.Subtract(myNum).ToString();
        }

        private void btnNtAdd_Click(object sender, EventArgs e)
        {
            var myNum = new MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _netTcpChannel.Add(myNum).ToString();
        }

        private void btnNtSubtract_Click(object sender, EventArgs e)
        {
            var myNum = new MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _netTcpChannel.Subtract(myNum).ToString();
        }
    }
}
