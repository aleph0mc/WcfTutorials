using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using wref = WindowsClient.ProductServiceReference;
using System.ServiceModel;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            int counter = 0;
            try
            {
                using (var ts = new TransactionScope(TransactionScopeOption.Required))
                {
                    var proxy = new wref.ProductClient();
                    proxy.AddCategory("Electronic Products");
                    counter = proxy.AddProduct();

                    MessageBox.Show($"Num products inserted: {counter.ToString()}");

                    proxy.Close();
                    ts.Complete();
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
