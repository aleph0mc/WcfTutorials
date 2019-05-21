using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcWebService
{
    /// <summary>
    /// Summary description for CalcWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string Message()
        {
            return "This is a Calculator Web Service.";
        }

        [WebMethod]
        public decimal Add(decimal A, decimal B)
        {
            return A + B;
        }

        [WebMethod]
        public decimal Subtract(decimal A, decimal B)
        {
            return A - B;
        }
    }
}
