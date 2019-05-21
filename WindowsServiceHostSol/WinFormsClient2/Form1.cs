using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wref = WinFormsClient2.MyMathServiceRef;

namespace WinFormsClient2
{
    public partial class Form1 : Form
    {
        wref.MathServiceClient _client = null;

        public Form1()
        {
            InitializeComponent();

            _client = new wref.MathServiceClient("MathService_NetTcp");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var myNum = new wref.MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };


            txtResult.Text = _client.Add(myNum).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            var myNum = new wref.MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            txtResult.Text = _client.Subtract(myNum).ToString();
        }

        private void btnAddAsync_Click(object sender, EventArgs e)
        {
            var myNum = new wref.MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            _client.AddCompleted += new EventHandler<wref.AddCompletedEventArgs>(client_AddCompleted);
            _client.AddAsync(myNum);
        }

        private void client_AddCompleted(object sender, wref.AddCompletedEventArgs e)
        {
            if (null == e.Error)
                txtResult.Text = e.Result.ToString();
            else
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSubtractAsync_Click(object sender, EventArgs e)
        {
            var myNum = new wref.MyNumbers
            {
                Number1 = int.Parse(txtNumber1.Text),
                Number2 = int.Parse(txtNumber2.Text)
            };

            _client.SubtractCompleted += new EventHandler<wref.SubtractCompletedEventArgs>(client_SubtractComplited);
            _client.SubtractAsync(myNum);
        }

        private void client_SubtractComplited(object sender, wref.SubtractCompletedEventArgs e)
        {
            if (null == e.Error)
                txtResult.Text = e.Result.ToString();
            else
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
