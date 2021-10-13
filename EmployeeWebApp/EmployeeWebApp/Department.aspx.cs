using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeData;

namespace EmployeeWebApp
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            department dptObj = new department();
            dptObj.name = txtDepartmentName.Text;
            employeeentity.departments.Add(dptObj);
            employeeentity.SaveChanges();
            btnReset_Click(sender,e);
            lblResult.Text = "Added.";

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            var result =employeeentity.departments.ToList().Find(obj => obj.departmentNumber == Convert.ToInt32(txtDepartmentId.Text));
            txtDepartmentName.Text = result.name;
            lblDepartmentID.Text = result.departmentNumber.ToString();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            department dptObj = new department();
            dptObj.name = txtDepartmentName.Text;
            dptObj.departmentNumber = Convert.ToInt32(lblDepartmentID.Text);
            employeeentity.Entry(dptObj).State = System.Data.Entity.EntityState.Modified;
            employeeentity.SaveChanges();
            btnReset_Click(sender, e);
            lblResult.Text = "Updated.";
        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            department dptObj = new department();
            dptObj.name = txtDepartmentName.Text;
            dptObj.departmentNumber = Convert.ToInt32(lblDepartmentID.Text);
            employeeentity.Entry(dptObj).State = System.Data.Entity.EntityState.Deleted;
            employeeentity.SaveChanges();
            btnReset_Click(sender, e);
            lblResult.Text = "Deleted.";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtDepartmentName.Text = string.Empty;
            txtDepartmentId.Text = string.Empty;
            lblDepartmentID.Text = string.Empty;
            lblResult.Text = string.Empty;
        }
    }
}