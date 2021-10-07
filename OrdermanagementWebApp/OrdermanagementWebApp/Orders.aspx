<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="OrdermanagementWebApp.Orders" %>

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
                        Purchase Amount
                    </td>
                    <td>
                        <asp:TextBox ID="txtPurchaseAmount" runat="server"></asp:TextBox>
                        <asp:Label ID="lblOrderid" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        Order Date
                    </td>
                    <td>
                        <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Customer ID
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlCustomerID" runat="server" >
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Salesman ID
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlSalesmanID" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"/>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
             
        </div>
        <asp:GridView ID="gvOrderDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvOrderDetails_RowCommand" OnRowDeleting="gvOrderDetails_RowDeleting" OnRowEditing="gvOrderDetails_RowEditing">
            <Columns>
                <asp:BoundField DataField="ord_no" HeaderText="Order Number" />
                <asp:BoundField DataField="purch_amt" HeaderText="Purchase Amount" />
                <asp:BoundField DataField="ord_date" HeaderText="Order Date" />
                <asp:BoundField DataField="customer_id" HeaderText="Cusotomer ID" />
                <asp:BoundField DataField="salesman_id" HeaderText="Salesman ID" />
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("ord_no") %>'>Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("ord_no") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>

</body>
</html>
