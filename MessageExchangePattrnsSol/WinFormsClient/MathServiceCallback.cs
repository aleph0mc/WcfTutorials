using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wref = WinFormsClient.MathServiceReference;

namespace WinFormsClient
{
    public class MathServiceCallback : wref.IMathServiceCallback
    {
        public void NotifyClientWhenPrintDone(string Message) => MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
