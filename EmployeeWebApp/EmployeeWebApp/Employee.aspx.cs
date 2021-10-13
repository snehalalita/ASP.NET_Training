using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeData;

namespace EmployeeWebApp
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
                employee empObj = new employee();
                var result = employeeentity.departments.ToList();
                
                foreach (var item in result)
                {
                    ddlDepartmentNumber.Items.Add(item.departmentNumber.ToString());   
                }

                var projResult = employeeentity.projects.ToList();
                foreach(var item in projResult)
                {
                    ddlProjectNumber.Items.Add(item.projectNumber.ToString());
                }
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            employee empObj = new employee();
            empObj.job_Title = txtJobTitle.Text;
            empObj.lastName = txtLastName.Text;
            empObj.firstName = txtFirstName.Text;
            empObj.birthday = DateTime.Parse(txtBirthday.Text);
            empObj.hiredate = DateTime.Parse(txtHireDate.Text);
            empObj.gender = txtGender.Text;
            empObj.departmentNumber = Convert.ToInt32(ddlDepartmentNumber.SelectedValue);
            empObj.projectNumber = Convert.ToInt32(ddlProjectNumber.SelectedValue);

            employeeentity.employees.Add(empObj);
            employeeentity.SaveChanges();
            btnReset_Click(sender, e);
            lblResult.Text = "Added.";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtJobTitle.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtBirthday.Text = string.Empty;
            txtHireDate.Text = string.Empty;
            tbEmployeeNumber.Text = string.Empty;
            lblEmployeeNumber.Text = string.Empty;
            lblResult.Text = string.Empty;
            ddlDepartmentNumber.SelectedIndex = 0;
            ddlProjectNumber.SelectedIndex = 0;

        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            employee empObj = new employee();
            var result = employeeentity.employees.ToList().Find(obj => obj.employeeNumber == Convert.ToInt32(tbEmployeeNumber.Text));
            txtJobTitle.Text = result.job_Title;
            txtLastName.Text = result.lastName;
            txtFirstName.Text = result.firstName;
            txtGender.Text = result.gender;
            txtBirthday.Text = result.birthday.ToString();
            txtHireDate.Text = result.hiredate.ToString();
            ddlDepartmentNumber.SelectedValue = result.departmentNumber.ToString();
            ddlProjectNumber.SelectedValue = result.projectNumber.ToString();

            lblEmployeeNumber.Text = result.employeeNumber.ToString();
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            employee empObj = new employee();
            empObj.employeeNumber=Convert.ToInt32( tbEmployeeNumber.Text);
            empObj.job_Title = txtJobTitle.Text;
            empObj.lastName = txtLastName.Text;
            empObj.firstName = txtFirstName.Text;
            empObj.birthday = DateTime.Parse(txtBirthday.Text);
            empObj.hiredate = DateTime.Parse(txtHireDate.Text);
            empObj.gender = txtGender.Text;
            empObj.departmentNumber = Convert.ToInt32(ddlDepartmentNumber.SelectedValue);
            empObj.projectNumber = Convert.ToInt32(ddlProjectNumber.SelectedValue);
            employeeentity.Entry(empObj).State = System.Data.Entity.EntityState.Modified;
            employeeentity.SaveChanges();
            btnReset_Click(sender, e);
            lblResult.Text = "Updated.";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeeManagementEntities employeeentity = new EmployeeManagementEntities();
            employee empObj = new employee();
            empObj.employeeNumber = Convert.ToInt32(tbEmployeeNumber.Text);
            empObj.job_Title = txtJobTitle.Text;
            empObj.lastName = txtLastName.Text;
            empObj.firstName = txtFirstName.Text;
            empObj.birthday = DateTime.Parse(txtBirthday.Text);
            empObj.hiredate = DateTime.Parse(txtHireDate.Text);
            empObj.gender = txtGender.Text;
            empObj.departmentNumber = Convert.ToInt32(ddlDepartmentNumber.SelectedValue);
            empObj.projectNumber = Convert.ToInt32(ddlProjectNumber.SelectedValue);

            employeeentity.Entry(empObj).State = System.Data.Entity.EntityState.Deleted;
            employeeentity.SaveChanges();
            btnReset_Click(sender, e);
            lblResult.Text = "Deleted.";
        }
    }
}