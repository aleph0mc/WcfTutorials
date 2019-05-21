using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wref = WinFormsClient.MathServiceReference;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        private wref.MathServiceClient _client = new wref.MathServiceClient();

        public Form1()
        {
            InitializeComponent();
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

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNumber1.Text);
                int num2 = int.Parse(txtNumber2.Text);

                var myNum = new wref.MyNumbers
                {
                    Number1 = num1,
                    Number2 = num2
                };

                var res = _client.Divide(myNum);
                txtResult.Text = res.ToString();

            }
            //catch (DivideByZeroException dex)
            //{
            //    MessageBox.Show(dex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (FaultException fex)
            //{
            //    //MessageBox.Show(fex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    // Show message according to fault code
            //    switch (fex.Code.Name)
            //    {
            //        case "DivisorAbove100":
            //            MessageBox.Show(fex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            break;
            //        case "DivisorIsZero":
            //            MessageBox.Show(fex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            break;
            //        default:
            //            MessageBox.Show(fex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            break;
            //    }
            //}
            catch (FaultException<wref.DivisionFault> fex)
            {
                var msg =
$@"{fex.Detail.Reason}
The following error occurred in {fex.Detail.Method}:
{fex.Detail.Message}";
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivideOneWay_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNumber1.Text);
                int num2 = int.Parse(txtNumber2.Text);

                var myNum = new wref.MyNumbers
                {
                    Number1 = num1,
                    Number2 = num2
                };

                _client.DivideOneWay(myNum);
            }
            catch (DivideByZeroException dex)
            {
                MessageBox.Show(dex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
