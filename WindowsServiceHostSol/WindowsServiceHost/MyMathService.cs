using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using MathServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WindowsServiceHost
{
    public partial class MyMathService : ServiceBase
    {
        private ServiceHost _host = null;

        public MyMathService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _host = new ServiceHost(typeof(MathService));
            _host.Open();
        }

        protected override void OnStop()
        {
            if (null != _host)
            {
                _host.Close();
                _host = null;
            }
        }
    }
}
