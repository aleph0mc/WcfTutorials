using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using wref = WindowsClient.ProductServiceReference;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        private wref.ProductClient _proxy = null;

        public Form1()
        {
            InitializeComponent();

            _proxy = new wref.ProductClient("ProductService_NetTcp");
        }

        private void btnProdCateg_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i < 6; i++)
                {
                    _proxy.AddCategory($"Prod_{i.ToString()}");

                    Thread.Sleep(2000);
                }
            }
            catch (FaultException fex)
            {
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
