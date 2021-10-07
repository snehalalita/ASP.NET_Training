using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrdermanagementWebApp
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbObj = new DbConnection();
            DataTable dtOrderResult = dbObj.getOrders();
            gvOrderDetails.DataSource = dtOrderResult;
            gvOrderDetails.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            
            int purchase_amount;
            string date;
            int customerID,salesmanID;
            purchase_amount = Convert.ToInt32(txtPurchaseAmount.Text);
            date = txtOrderDate.Text;
            customerID = Convert.ToInt32(txtCustomerID.Text);
            salesmanID = Convert.ToInt32(txtSalesmanID.Text);

            DbConnection dbObj = new DbConnection();
            dbObj.insertOrder(purchase_amount,date,customerID,salesmanID);
            lbl1.Text = "Record added successfully";
            DataTable dtOrderResult = dbObj.getOrders();
            gvOrderDetails.DataSource = dtOrderResult;
            gvOrderDetails.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.updateOrder(Convert.ToInt32(lblOrderid.Text),Convert.ToInt32( txtPurchaseAmount.Text), txtOrderDate.Text, Convert.ToInt32(txtCustomerID.Text), Convert.ToInt32(txtSalesmanID.Text));
            DataTable dtOrderResult = dbConnection.getOrders();
            gvOrderDetails.DataSource = dtOrderResult;
            gvOrderDetails.DataBind();
        }

        protected void gvOrderDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int orderid = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.getOrderByID(orderid);
               txtPurchaseAmount.Text = dt.Rows[0][1].ToString();
                txtOrderDate.Text = dt.Rows[0][2].ToString();
                txtCustomerID.Text = dt.Rows[0][3].ToString();
                txtSalesmanID.Text = dt.Rows[0][4].ToString();
                lblOrderid.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.deleteOrderByID(orderid);
                DataTable dtOrderResult = dbConnection.getOrders();
                gvOrderDetails.DataSource = dtOrderResult;
                gvOrderDetails.DataBind();
            
        }
        }

        protected void gvOrderDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvOrderDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}