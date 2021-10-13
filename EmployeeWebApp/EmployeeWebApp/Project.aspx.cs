using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeData;

namespace EmployeeWebApp
{
    public partial class Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            project projObj = new project();
            projObj.name = txtProjectName.Text;
            projObj.start_date=DateTime.Parse(txtProjectStartDate.Text);
            employeeentity.projects.Add(projObj);
            employeeentity.SaveChanges();
            btnReset_Click(sender, e);
            lblResult.Text = "Added.";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtProjectName.Text = string.Empty;
            txtProjectStartDate.Text = string.Empty;
            lblProjectNo.Text = string.Empty;
            lblResult.Text = string.Empty;
            tbProjectNumber.Text = string.Empty;
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            var result = employeeentity.projects.ToList().Find(obj => obj.projectNumber == Convert.ToInt32(tbProjectNumber.Text));
            txtProjectName.Text = result.name;
            txtProjectStartDate.Text = result.start_date.ToString();
            lblProjectNo.Text = result.projectNumber.ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            project projObj = new project();
            projObj.projectNumber = Convert.ToInt32(tbProjectNumber.Text);
            projObj.name = txtProjectName.Text;
            projObj.start_date = DateTime.Parse(txtProjectStartDate.Text);
            employeeentity.Entry(projObj).State = System.Data.Entity.EntityState.Modified;
            employeeentity.SaveChanges();
            btnReset_Click(sender, e);
            lblResult.Text = "Updated.";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            project projObj = new project();
            projObj.projectNumber = Convert.ToInt32(lblProjectNo.Text);
            projObj.name = txtProjectName.Text;
            projObj.start_date = DateTime.Parse(txtProjectStartDate.Text);
            employeeentity.Entry(projObj).State = System.Data.Entity.EntityState.Deleted;
            employeeentity.SaveChanges();
            btnReset_Click(sender, e);
            lblResult.Text = "Deleted.";
        }
    }
}