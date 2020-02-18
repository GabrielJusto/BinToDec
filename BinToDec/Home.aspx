<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BinToDec.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Binary to decimal converter<br />
            <br />
            Decimal:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="TextBox_Decimal" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Convert" />
            <br />
            Binary:<br />
            <asp:Label ID="Label_Binary" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            Binary:<br />
            <asp:TextBox ID="TextBox_Binary" runat="server"></asp:TextBox>
            <asp:Button ID="Button_BinToDec" runat="server" OnClick="Button_BinToDec_Click" Text="Convert" />
            <br />
            <br />
            Decimal:<br />
            <asp:Label ID="Label_Decimal" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
