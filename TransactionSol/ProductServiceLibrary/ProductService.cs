using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(TransactionIsolationLevel = System.Transactions.IsolationLevel.Serializable )]
    public class ProductService : IProduct
    {
        [OperationBehavior(TransactionScopeRequired =true, TransactionAutoComplete =true)]
        public int AddCategory(string CategoryName)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            int categoryID = 0;
            int counter = 0;
            SqlParameter outParam = null;

            try
            {
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

                return categoryID;
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

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public int AddProduct(int CategoryID)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            int counter = 0;

            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = @"data source=.\MSSQL2016DEV;initial catalog=TransactionDemo;integrated security=true;";
                cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Products_Insert";
                cmd.Parameters.Add(new SqlParameter("@CategoryID", CategoryID));

                cn.Open();
                counter = cmd.ExecuteNonQuery();

                return counter;
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
