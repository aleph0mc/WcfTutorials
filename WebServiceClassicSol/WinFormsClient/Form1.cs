using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsClient.CalcWebServiceRef;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        private CalcWebServiceRef.CalcWebServiceSoapClient _client = null;

        public Form1()
        {
            InitializeComponent();

            _client = new CalcWebServiceRef.CalcWebServiceSoapClient();
        }

        private void Client_AddCompletedEvent(object sender, AddCompletedEventArgs e)
        {
            if (null == e.Error)
                txtResult.Text = e.Result.ToString();
            else
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var num1 = decimal.Parse(txtNumber1.Text);
            var num2 = decimal.Parse(txtNumber2.Text);

            // async invoke
            _client.AddCompleted += new EventHandler<CalcWebServiceRef.AddCompletedEventArgs>(Client_AddCompletedEvent);
            _client.AddAsync(num1, num2);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            var num1 = decimal.Parse(txtNumber1.Text);
            var num2 = decimal.Parse(txtNumber2.Text);

            var res = _client.Subtract(num1, num2);
            txtResult.Text = res.ToString();
        }
    }
}
