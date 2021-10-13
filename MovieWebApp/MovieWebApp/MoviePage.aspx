<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MoviePage.aspx.cs" Inherits="MovieWebApp.MoviePage" %>

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
                    <th>Movie Id</th>
                    <td></td>
                </tr>
                 <tr>
                    <th>Movie Name</th>
                    <td><asp:TextBox ID="txtMovieName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <th>Movie Type</th>
                    <td><asp:TextBox ID="txtMovieType" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <th>Movie Description</th>
                    <td><asp:TextBox ID="txtMovieDesc" runat="server"></asp:TextBox></td>
                </tr>

                
            </table>
            <br />
            <asp:Button ID="btn_Save" runat="server" OnClick="btn_Save_Click" Text="Save" />
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="height: 35px" Text="Delete" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            <br />
            <br />
            Movie Id <asp:TextBox ID="txtMovieId" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
