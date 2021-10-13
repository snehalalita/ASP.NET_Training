<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EmployeeWebApp.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>Employee Number</th>
                    <td>
                         <asp:Label ID="lblEmployeeNumber" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <th>Job Title</th>
                    <td>
                        <asp:TextBox ID="txtJobTitle" runat="server"></asp:TextBox>
                       
                    </td>
                </tr>
                <tr>
                    <th>Last Name</th>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>First Name</th>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Gender</th>
                    <td>
                        <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Birthday</th>
                    <td>
                        <asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Hire Date</th>
                    <td>
                        <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Department Number</th>
                    <td>
                        <asp:DropDownList ID="ddlDepartmentNumber" runat="server" >
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <th>Project Number</th>
                    <td>
                        <asp:DropDownList ID="ddlProjectNumber" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"  />
            &nbsp;&nbsp;
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"   />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            <br />
     
        <br />
        <br />
        Search By Employee Number:
        <asp:TextBox ID="tbEmployeeNumber" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Search" runat="server"  Text="Search" OnClick="btn_Search_Click" />
&nbsp;&nbsp;&nbsp;
        <br />
        </div>
    </form>
</body>
</html>
