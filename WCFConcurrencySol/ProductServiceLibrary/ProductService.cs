using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using static System.Console;

namespace ProductServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    // ConcurrencyMode default is Single
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ProductService : IProduct
    {
        public void AddCategory(string CategoryName)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            int categoryID = 0;
            int counter = 0;
            SqlParameter outParam = null;

            try
            {
                WriteLine($"Start time {DateTime.Now.ToString("hh:mm:ss")} Thread ID: {Thread.CurrentThread.ManagedThreadId.ToString()}");
                Thread.Sleep(5000);

                cn = new SqlConnection();
                cn.ConnectionString = @"data source=.\MSSQL2016DEV;initial catalog=TransactionDemo;integrated security=true;";
                cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Categories_Insert";
                cmd.Parameters.Add(new SqlParameter("@CategoryName", @CategoryName));
                outParam = new SqlParameter("@CategoryID", SqlDbType.Int);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);

                cn.Open();
                counter = cmd.ExecuteNonQuery();
                categoryID = int.Parse(outParam.Value.ToString());

                WriteLine($"Category {CategoryName} has been added successfully by thread {Thread.CurrentThread.ManagedThreadId.ToString()} at {DateTime.Now.ToString("hh:mm:ss")}");
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
            finally
            {
                if (null != cn)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
        }
    }
}
