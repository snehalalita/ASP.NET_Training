using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrdermanagementWebApp
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbObj = new DbConnection();
            DataTable dtSalesmanResult = dbObj.getCustomers();
            gvCustomerDetails.DataSource = dtSalesmanResult;
            gvCustomerDetails.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string customername = "";
            string customercity = "";
            int grade;
            int salesmanID;
            customername = txtCustomerName.Text;
            customercity = txtCustomerCity.Text;
            grade = Convert.ToInt32(txtCustomerGrade.Text);
            salesmanID = Convert.ToInt32(txtSalesmanID.Text);

            DbConnection dbObj = new DbConnection();
            dbObj.insertCustomer(customername,customercity,grade,salesmanID);
            lbl1.Text = "Record added successfully";
            DataTable dtCustomerResult = dbObj.getCustomers();
            gvCustomerDetails.DataSource = dtCustomerResult;
            gvCustomerDetails.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.updateCustomer(Convert.ToInt32(lblCustomerid.Text), txtCustomerName.Text, txtCustomerCity.Text,Convert.ToInt32( txtCustomerGrade.Text),Convert.ToInt32(txtSalesmanID.Text));
            DataTable dtCustomerResult = dbConnection.getCustomers();
            gvCustomerDetails.DataSource = dtCustomerResult;
            gvCustomerDetails.DataBind();
        }

        protected void gvCustomerDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int customerid = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.getCustomerByID(customerid);
               txtCustomerName.Text = dt.Rows[0][1].ToString();
               txtCustomerCity.Text = dt.Rows[0][2].ToString();
               txtCustomerGrade.Text = dt.Rows[0][3].ToString();
                txtSalesmanID.Text = dt.Rows[0][4].ToString();
                lblCustomerid.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.deleteCustomerByID(customerid);
                DataTable dtSalesmanResult = dbConnection.getCustomers();
                gvCustomerDetails.DataSource = dtSalesmanResult;
                gvCustomerDetails.DataBind();
            }
        }

    

    protected void gvCustomerDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvCustomerDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}