<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="EmployeeWebApp.Department" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
             <form id="form1" runat="server">
        <div>
            <b><p style="margin-left: 120px">
                DEPARTMENT&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </p></b>
            <table>
                 <tr>
                    <th>Department Number
                        
                    </th>
                    <td> 
                        <asp:Label ID="lblDepartmentID" runat="server"></asp:Label>
                       
                    </td>
                    
                </tr>
                <tr>
                    <th>Department Name 
                        
                    </th>
                    <td> 
                        <asp:TextBox ID="txtDepartmentName" runat="server"></asp:TextBox>
                       
                        
                       
                    </td>
                    
                </tr>
            </table>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"  />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_Delete" runat="server" OnClick="btn_Delete_Click" Text="Delete" />
            <br />
                    
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl" runat="server" Text="Id"></asp:Label>
            :
            <asp:TextBox ID="txtDepartmentId" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            <br />
        </div>
    </form>
</body>
</html>
