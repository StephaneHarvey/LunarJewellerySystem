<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 640px;
        }
        .auto-style2 {
            margin-left: 760px;
        }
        .auto-style3 {
            margin-left: 880px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <link href="StyleSheet/Customer.css" rel="stylesheet" />
       </br>
        <div style="margin-left: 840px">
            <asp:Image ID="Image1" runat="server" Height="124px" ImageUrl="~/StyleSheet/Lunar.png" Width="146px" />
        </div>
        </br>
        </br>
        </br>
        </br>
        </br>
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Are You Sure You Would Like To Delete The Customer?" Font-Bold="True" Font-Italic="True" Font-Names="Akzidenz-Grotesk Pro Bold" Font-Size="X-Large" ForeColor="#66FFFF"></asp:Label>
        </div>
        <br />
        <br />
        <div class="auto-style2">
            <asp:Button ID="btnYes" runat="server"  Text="Yes" BackColor="#9966FF" Font-Bold="True" Font-Italic="True" Font-Names="Akzidenz-Grotesk Pro Bold" Font-Size="X-Large" ForeColor="White" Height="49px" OnClick="btnYes_Click1" Width="204px" />
            <asp:Button ID="btnNo" runat="server" Text="No" BackColor="#9966FF" Font-Bold="True" Font-Italic="True" Font-Names="Akzidenz-Grotesk Pro Bold" Font-Size="X-Large" ForeColor="White" Height="49px" Width="204px" OnClick="btnNo_Click" />
        </div>
        <div class="auto-style3">
        </div>
    </form>
</body>
</html>
