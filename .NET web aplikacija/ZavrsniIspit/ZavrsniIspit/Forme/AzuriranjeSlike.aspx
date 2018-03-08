<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AzuriranjeSlike.aspx.cs" Inherits="ZavrsniIspit.Forme.AzuriranjeSlike" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ažuriranje slike</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Putanja do slike:</td>
                    <td><asp:Label ID="lblPutanjaDoSlike" runat="server" Font-Bold="true"></asp:Label></td>                 
                </tr>
                <tr>
                    <td>Upis nove putanje</td>
                    <td><asp:TextBox ID="txtPutanjaDoSlike" runat="server" Width="200px"></asp:TextBox></td>
                    <td><asp:Button ID="btnSpremiPutanju" runat="server" Text="Spremi putanju" OnClick="btnSpremiPutanju_Click"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblInfo" runat="server" Font-Bold="true"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>