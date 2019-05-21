using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wref = WinFormsClient.MathServiceReference;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        //private MathServiceReference.MathServiceClient _client = new MathServiceReference.MathServiceClient();

        private wref.MathServiceClient _client = null;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumber1.Text);
            int num2 = int.Parse(txtNumber2.Text);

            var myNum = new MathServiceReference.MyNumbers
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

            var myNum = new MathServiceReference.MyNumbers
            {
                Number1 = num1,
                Number2 = num2
            };

            var res = _client.Subtract(myNum);
            txtResult.Text = res.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var callback = new MathServiceCallback();
            var context = new InstanceContext(callback);
            _client = new wref.MathServiceClient(context);

            _client.SignIn(WindowsIdentity.GetCurrent().Name);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _client.SignOut(WindowsIdentity.GetCurrent().Name);
        }

        private void btnPrintLogFiles_Click(object sender, EventArgs e)
        {
            _client.StartPrintingLogFiles("Log information has been printed successfully...");
        }
    }
}
