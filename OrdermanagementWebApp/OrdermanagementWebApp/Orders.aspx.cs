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
            if (!IsPostBack)
            {
                DbConnection dbObj = new DbConnection();
                DataTable dtOrderResult = dbObj.getOrders();
                gvOrderDetails.DataSource = dtOrderResult;
                gvOrderDetails.DataBind();
                DataTable dtCustomerResult = dbObj.getCustomers();
                ddlCustomerID.Items.Add("Select");
                for (int i = 0; i < dtCustomerResult.Rows.Count; i++)
                {
                    ddlCustomerID.Items.Add(new ListItem(dtCustomerResult.Rows[i][0].ToString() + "-" + dtCustomerResult.Rows[i][1].ToString(), dtCustomerResult.Rows[i][0].ToString()));
                }

                DataTable dtSalesmanResult = dbObj.getSalesmans();
                ddlSalesmanID.Items.Add("Select");
                for (int i = 0; i < dtSalesmanResult.Rows.Count; i++)
                {
                    ddlSalesmanID.Items.Add(new ListItem(dtSalesmanResult.Rows[i][0].ToString() + "-" + dtSalesmanResult.Rows[i][1].ToString(), dtSalesmanResult.Rows[i][0].ToString()));
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            
            int purchase_amount;
            string date;
            int customerID,salesmanID;
            purchase_amount = Convert.ToInt32(txtPurchaseAmount.Text);
            date = txtOrderDate.Text;
            customerID = Convert.ToInt32(ddlCustomerID.SelectedValue.ToString()) ;
            salesmanID = Convert.ToInt32(ddlSalesmanID.SelectedValue.ToString());

            DbConnection dbObj = new DbConnection();
            dbObj.insertOrder(purchase_amount,date,customerID,salesmanID);
            btnReset_Click(sender, e);
            lbl1.Text = "Record added successfully";
            DataTable dtOrderResult = dbObj.getOrders();
            gvOrderDetails.DataSource = dtOrderResult;
            gvOrderDetails.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            int customerID = Convert.ToInt32(ddlCustomerID.SelectedValue.ToString());
            int salesmanID = Convert.ToInt32(ddlSalesmanID.SelectedValue.ToString());
            int orderNo = Convert.ToInt32(lblOrderid.Text);
            double purchAmount = Convert.ToDouble(txtPurchaseAmount.Text);
            string ord_date = txtOrderDate.Text;
            dbConnection.updateOrder(orderNo, purchAmount,ord_date ,customerID,salesmanID);
            btnUpdate_Click(sender, e);
            lbl1.Text = "Order updated successfully";
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
                ddlCustomerID.SelectedValue= dt.Rows[0][3].ToString();
                ddlSalesmanID.SelectedValue = dt.Rows[0][4].ToString();
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

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtPurchaseAmount.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            ddlCustomerID.SelectedIndex = 0;
            ddlSalesmanID.SelectedIndex = 0;
            lblOrderid.Text = string.Empty;
        }
    }
}