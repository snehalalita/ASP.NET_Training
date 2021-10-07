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
            if (!IsPostBack)
            {


                DbConnection dbObj = new DbConnection();
                DataTable dtCustomerResult = dbObj.getCustomers();
                gvCustomerDetails.DataSource = dtCustomerResult;
                gvCustomerDetails.DataBind();
                ddlSalesmanID.Items.Add("Select");
                DataTable dtSalesmanResult = dbObj.getSalesmans();
                for (int i = 0; i < dtSalesmanResult.Rows.Count; i++)
                {
                    ddlSalesmanID.Items.Add(new ListItem(dtSalesmanResult.Rows[i][0].ToString() + "-" + dtSalesmanResult.Rows[i][1].ToString(), dtSalesmanResult.Rows[i][0].ToString()));
                }
            }
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
            salesmanID = Convert.ToInt32(ddlSalesmanID.SelectedValue.ToString());

            DbConnection dbObj = new DbConnection();
            dbObj.insertCustomer(customername,customercity,grade,salesmanID);
            lbl1.Text = "Record added successfully";
            btnReset_Click(sender,e);
            DataTable dtCustomerResult = dbObj.getCustomers();
            gvCustomerDetails.DataSource = dtCustomerResult;
            gvCustomerDetails.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.updateCustomer(Convert.ToInt32(lblCustomerid.Text), txtCustomerName.Text, txtCustomerCity.Text,Convert.ToInt32( txtCustomerGrade.Text),Convert.ToInt32(ddlSalesmanID.SelectedValue.ToString()));
            btnReset_Click(sender, e);
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
                ddlSalesmanID.SelectedValue = dt.Rows[0][4].ToString();
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

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            txtCustomerCity.Text = string.Empty;
            txtCustomerGrade.Text = string.Empty;
            ddlSalesmanID.SelectedIndex = 0;
        }
    }
}