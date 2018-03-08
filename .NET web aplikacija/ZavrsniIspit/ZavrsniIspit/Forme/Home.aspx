<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ZavrsniIspit.Aplikacija.ZavrsniIspit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zavrsni ispit</title>
    <link rel="stylesheet" type="text/css" href="../Static/stilovi.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Pasmina</td>
                </tr>
                <tr>
                    <td>
                        <asp:ListBox ID="lbPasmine" runat="server" AutoPostBack="true" AppendDataBoundItems="false" OnSelectedIndexChanged="lbPasmine_SelectedIndexChanged"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="gvKrave" runat="server" CellPadding="3" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">                            
                            
                            <Columns>
                                <asp:ImageField DataImageUrlField="Putanja" ControlStyle-Width="40px"
                                    ControlStyle-Height = "40px"/>
                                <asp:HyperLinkField DataNavigateUrlFields="Ime" DataNavigateUrlFormatString="DnevnaProizvodnja.aspx?Ime={0}" Text="Dnevna proizvodnja" />
                                <asp:HyperLinkField DataNavigateUrlFields="Ime" DataNavigateUrlFormatString="AzuriranjeSlike.aspx?Ime={0}" Text="Ažuriranje slike"/>
                            </Columns>
                            
                            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                            <HeaderStyle BackColor="#A55129" ForeColor="White" Font-Bold="True"></HeaderStyle>

                            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />

                            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510"></RowStyle>
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#FFF1D4" />
                            <SortedAscendingHeaderStyle BackColor="#B95C30" />
                            <SortedDescendingCellStyle BackColor="#F1E5CE" />
                            <SortedDescendingHeaderStyle BackColor="#93451F" />
                        </asp:GridView>
                    </td>
                </tr> 
            </table>
        </div>
    </form>
</body>
</html>