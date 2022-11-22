<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="EncuestaUH.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            Cedula: <asp:TextBox ID="tcedula" runat="server"></asp:TextBox>
            <br />
            nombre:<asp:TextBox ID="tnombre" runat="server"></asp:TextBox>
            <br />
            <br />
            Genero: <asp:RadioButton ID="rm" Text="Masculino" runat="server" /><asp:RadioButton ID="rf" Text="Femenino" runat="server" />
            <br />
            <br />
            <asp:Button ID="bsiguiente" runat="server" Height="55px" Text="Siguiente" Width="94px" OnClick="bsiguiente_Click" />
        </div>
    </form>
</body>
</html>
