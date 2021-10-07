using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OrdermanagementWebApp
{
    public class DbConnection
    {
        #region disconnectedapproach

        public void insertSalesman(string SalesmanName, string city, string commission)
        {
            string query = "insert into salesman values('" + SalesmanName + "','" + city + "'," + commission + ")";
            ExecuteQuery(query);
        }
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        public void updateSalesman(int SalesmanID, string SalesmanName, string city, string commission)
        {
            string query="update salesman set name='" + SalesmanName + "',city='" + city + "',commission=" + commission + "where salesman_id=" + SalesmanID + "";
            ExecuteQuery(query);
        }

        public void deleteSalesmanByID(int SalesmanID)
        {
            string query="delete from salesman where salesman_id=" + SalesmanID + "";
            ExecuteQuery(query);
        }

        public DataTable getSalesmans()
        {
            string query="select * from salesman ";

            DataTable dt = ExecuteQuery(query);
           
            return dt;
        }




        public DataTable getSalesmanByID(int salesmanID)
        {
            string query="select * from salesman where salesman_id=" + salesmanID + "";

            DataTable dt = ExecuteQuery(query);
            
           
            return dt;
        }
        #endregion
        #region salesman
        /* public void insertSalesman(string SalesmanName,string city,string commission)
         {
             SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
             SqlCommand sqlCommand=new SqlCommand("insert into salesman values('" + SalesmanName + "','" + city + "'," + commission + ")", sqlConnection);
             sqlConnection.Open();
             sqlCommand.ExecuteNonQuery();
             sqlConnection.Close();
         }

         public void updateSalesman(int SalesmanID, string SalesmanName, string city, string commission)
         {
             SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
             SqlCommand sqlCommand = new SqlCommand("update salesman set name='"+SalesmanName+"',city='"+city+"',commission="+commission+"where salesman_id="+SalesmanID+"", sqlConnection);
             sqlConnection.Open();
             sqlCommand.ExecuteNonQuery();
             sqlConnection.Close();
         }

         public void deleteSalesmanByID(int SalesmanID)
         {
             SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
             SqlCommand sqlCommand = new SqlCommand("delete from salesman where salesman_id=" + SalesmanID + "", sqlConnection);
             sqlConnection.Open();
             sqlCommand.ExecuteNonQuery();
             sqlConnection.Close();
         }

         public DataTable getSalesmans()
         {
             SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
             SqlCommand sqlCommand = new SqlCommand("select * from salesman ", sqlConnection);
             sqlConnection.Open();
             SqlDataReader dr=sqlCommand.ExecuteReader();
             DataTable dt = new DataTable();
             dt.Load(dr);
             sqlConnection.Close();
             return dt;
         }




         public DataTable getSalesmanByID(int salesmanID)
         {
             SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
             SqlCommand sqlCommand = new SqlCommand("select * from salesman where salesman_id="+salesmanID+"", sqlConnection);
             sqlConnection.Open();
             SqlDataReader dr = sqlCommand.ExecuteReader();
             DataTable dt = new DataTable();
             dt.Load(dr);
             sqlConnection.Close();
             return dt;
         }*/
        #endregion

        #region customer
        public void insertCustomer(string CustomerName, string city, int grade,int SalesmanID)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into customer values('" + CustomerName + "','" + city + "'," + grade +","+SalesmanID+ ")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }


        public void updateCustomer(int CustomerID, string CustomerName, string city, int grade, int SalesmanID)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("update customer set cust_name='" + CustomerName + "',city='" + city + "',grade=" +grade+",salesman_id="+SalesmanID + " where customer_id=" + CustomerID + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void deleteCustomerByID(int CustomerID)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("delete from customer where customer_id=" + CustomerID + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable getCustomers()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from customer ", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }

        public DataTable getCustomerByID(int customerID)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from customer where customer_id=" + customerID + "", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }

        #endregion

        #region orders
        public void insertOrder(int purchase_amount,string date,int customerID, int SalesmanID)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into orders values(" + purchase_amount + ",'" + date + "'," + customerID+ "," + SalesmanID + ")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }


        public void updateOrder(int OrderNo, double purchase_amount, string date, int customerID, int SalesmanID)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("update orders set purch_amt=" + purchase_amount + ",ord_date='" + date + "',customer_id=" + customerID + ",salesman_id=" + SalesmanID + " where ord_no=" + OrderNo + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void deleteOrderByID(int OrderNo)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("delete from orders where order_no=" + OrderNo + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable getOrders()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from orders", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }

        public DataTable getOrderByID(int OrderNo)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=SalesDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from orders where ord_no=" + OrderNo+ "", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        #endregion
    }
}