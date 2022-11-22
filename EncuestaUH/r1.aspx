<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="r1.aspx.cs" Inherits="EncuestaUH.r1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="429px" ImageUrl="~/Captura de tela 2022-11-08 195839.jpg" Width="599px" />
            <br />
            <br />
            <br />
            Pregunta 1
            <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="106px">
                <asp:ListItem>a</asp:ListItem>
                <asp:ListItem>b</asp:ListItem>
                <asp:ListItem>c</asp:ListItem>
                <asp:ListItem>d</asp:ListItem>
            </asp:DropDownList>

            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="bcontinuar" runat="server" Text="Siguiente" OnClick="bcontinuar_Click" />

        </div>
    </form>
</body>
</html>
