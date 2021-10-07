using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrdermanagementWebApp
{
    public partial class Salesman : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbObj = new DbConnection();
            DataTable dtSalesmanResult = dbObj.getSalesmans();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string salesmanname = "";
            string salesmancity = "";
            string commission = "";
            salesmanname = txtSalesmanName.Text;
            salesmancity = txtSalesmanCity.Text;
            commission = txtSalesmanCommission.Text;
            DbConnection dbObj = new DbConnection();
            dbObj.insertSalesman(salesmanname, salesmancity, commission);
            Label1.Text = "Record added successfully";
            DataTable dtSalesmanResult = dbObj.getSalesmans();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();
        }

     
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.updateSalesman(Convert.ToInt32(lblSalesmanid.Text), txtSalesmanName.Text, txtSalesmanCity.Text, txtSalesmanCommission.Text);
            DataTable dtSalesmanResult = dbConnection.getSalesmans();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();
        }

        protected void gvSalesmanDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int salesmanid = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.getSalesmanByID(salesmanid);
                txtSalesmanName.Text = dt.Rows[0][1].ToString();
                txtSalesmanCity.Text = dt.Rows[0][2].ToString();
                txtSalesmanCommission.Text = dt.Rows[0][3].ToString();
                lblSalesmanid.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.deleteSalesmanByID(salesmanid);
                DataTable dtSalesmanResult = dbConnection.getSalesmans();
                gvSalesmanDetails.DataSource = dtSalesmanResult;
                gvSalesmanDetails.DataBind();
            }
        }

        protected void gvSalesmanDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvSalesmanDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}