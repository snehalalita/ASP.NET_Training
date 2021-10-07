<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salesman.aspx.cs" Inherits="OrdermanagementWebApp.Salesman" %>

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
                    <td>
                        Salesman Name
                   </td>
                    <td>
                        <asp:TextBox ID="txtSalesmanName" runat="server"></asp:TextBox>
                        <asp:Label ID="lblSalesmanid" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Salesman City
                    </td>
                    <td>
                        <asp:TextBox ID="txtSalesmanCity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Salesman Commission
                    </td>
                    <td>
                        <asp:TextBox ID="txtSalesmanCommission" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"/>
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>
          
                <asp:GridView ID="gvSalesmanDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvSalesmanDetails_RowCommand" OnRowDeleting="gvSalesmanDetails_RowDeleting" OnRowEditing="gvSalesmanDetails_RowEditing" >
                    <Columns>
                        <asp:BoundField DataField="salesman_id" HeaderText="Salesman ID" />
                        <asp:BoundField DataField="name" HeaderText="Salesman Name" />
                        <asp:BoundField DataField="city" HeaderText="Salesman City" />
                        <asp:BoundField DataField="commission" HeaderText="Salesman Commission" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("salesman_id") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("salesman_id") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
       
            
        </div>
    </form>
</body>
</html>
