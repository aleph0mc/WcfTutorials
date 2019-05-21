using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rsRef = WinFormsWebSrvSol.ReportServiceReference;
using wref = WinFormsWebSrvSol.ReportSvrWebRef;

namespace WinFormsWebSrvSol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var rs = new rsRef.ReportingService2010SoapClient();
            rs.Open();

            rs.Close();

            var wrs = new wref.ReportingService2010();
            wrs.Credentials = System.Net.CredentialCache.DefaultCredentials;

            var sb = wrs.ListMySubscriptions("http://localhost/reports");


        }
    }
}
