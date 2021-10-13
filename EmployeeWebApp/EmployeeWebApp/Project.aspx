<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="EmployeeWebApp.Project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <p style="margin-left: 120px">
                PROJECT<br />
            </p>
           
            <table> 
                <tr>
                    <th class="auto-style1">Project Number 
                        
                    </th>
                    <td class="auto-style1"> 
                        
                       
                        <asp:Label ID="lblProjectNo" runat="server"></asp:Label>
                       
                    </td>
                    
                </tr>
                <tr>
                    <th class="auto-style1">Project Name 
                        
                    </th>
                    <td class="auto-style1"> 
                        <asp:TextBox ID="txtProjectName" runat="server"></asp:TextBox>
                       
                        
                       
                    </td>
                    
                </tr>
                <tr>
                    <th>Start Date 
                        
                    </th>
                    <td> 
                        <asp:TextBox ID="txtProjectStartDate" runat="server"></asp:TextBox>
                       

                    </td>
                    
                </tr>
            </table>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"  />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"  />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"  />
        
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        
        Search By Project Number:
        <asp:TextBox ID="tbProjectNumber" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Search" runat="server" Text="Search" OnClick="btn_Search_Click" />
&nbsp;&nbsp;&nbsp;
         <br />
        </div>
    </form>
</body>
</html>
