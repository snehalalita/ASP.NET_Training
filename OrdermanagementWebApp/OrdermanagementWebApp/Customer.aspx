<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="OrdermanagementWebApp.Customer" %>

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
                        Customer Name
                    </td>
                    <td>
                        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
                        <asp:Label ID="lblCustomerid" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Customer City
                    </td>
                    <td>
                        <asp:TextBox ID="txtCustomerCity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Customer Grade
                    </td>
                    <td>
                        <asp:TextBox ID="txtCustomerGrade" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Salesman ID
                    </td>
                    <td>
                        <asp:TextBox ID="txtSalesmanID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
                        <asp:Button ID="btnReset" runat="server" Text="Reset"/>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
             
        </div>
        <asp:GridView ID="gvCustomerDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvCustomerDetails_RowCommand" OnRowDeleting="gvCustomerDetails_RowDeleting" OnRowEditing="gvCustomerDetails_RowEditing">
            <Columns>
                <asp:BoundField DataField="customer_id" HeaderText="Customer ID" />
                <asp:BoundField DataField="cust_name" HeaderText="Customer Name" />
                <asp:BoundField DataField="city" HeaderText="Customer City" />
                <asp:BoundField DataField="grade" HeaderText="Grade" />
                <asp:BoundField DataField="salesman_id" HeaderText="Salesman ID" />
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server"  CommandName="Edit" CommandArgument='<%# Eval("customer_id") %>'>Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server"  CommandName="Delete" CommandArgument='<%# Eval("customer_id") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
