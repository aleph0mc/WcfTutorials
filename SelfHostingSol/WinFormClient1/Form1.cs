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
        private IMathService _channel = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var endpoint = new EndpointAddress("net.tcp://localhost:6666/MathService");
            _channel = ChannelFactory<IMathService>.CreateChannel(new NetTcpBinding(), endpoint);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var myNum = new MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _channel.Add(myNum).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            var myNum = new MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _channel.Subtract(myNum).ToString();
        }
    }
}
