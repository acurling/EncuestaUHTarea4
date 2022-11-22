<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="r2.aspx.cs" Inherits="EncuestaUH.r2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <br />
            <br />
            <br />
            Pregunta 2
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="108px">
                <asp:ListItem>a</asp:ListItem>
                <asp:ListItem>b</asp:ListItem>
                <asp:ListItem>c</asp:ListItem>
                <asp:ListItem>d</asp:ListItem>
            </asp:DropDownList>

            <br />
            <br />
            <br />
            <asp:Button ID="Salvar" runat="server" Text="Salvar" Height="37px" OnClick="Salvar_Click" Width="138px" />
             <br />
             <br />
             <asp:Label ID="Label1" runat="server"></asp:Label>
             <br />
             <br />
             <asp:Label ID="Label2" runat="server" Text="Nota:"></asp:Label>
             <br />
             <asp:GridView ID="GridView1" runat="server" Visible="False">
             </asp:GridView>
             <br />
             <br />
            <br />
            <br />
            <asp:Button ID="biniciar" runat="server" Text="Nueva encuesta" OnClick="biniciar_Click" Visible="False" />
        </div>
    </form>
</body>
</html>
