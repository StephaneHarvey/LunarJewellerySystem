<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDefault.aspx.cs" Inherits="CustomerDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <link href="StyleSheet/Customer.css" rel="stylesheet" />
        <br />
        <br />
        <div style="margin-left: 760px">
            <asp:Image ID="Image1" runat="server" Height="135px" Width="147px" ImageUrl="~/StyleSheet/Lunar.png" />
        </div>
        <br />
         <div style="margin-left: 400px"><asp:ListBox ID="lstCustomers" runat="server" Height="514px" Width="835px" BackColor="#9966FF" Font-Names="Akzidenz-Grotesk Pro Bold" Font-Bold="True" Font-Italic="True"></asp:ListBox>
             <br />
        </div>
             <div class="auto-style2">
                 <asp:Label ID="lblError" runat="server" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="White" Font-Bold="True" Font-Italic="True"></asp:Label>
                 <br />
                 <asp:Label ID="lblPostCode" runat="server" Text="Please Enter a Post Code" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="White" Font-Bold="True" Font-Italic="True"></asp:Label>
                 <asp:TextBox ID="txtPostCode" runat="server" Height="26px" Width="258px" BackColor="#9966FF" Font-Names="Akzidenz-Grotesk Pro Bold" Font-Bold="True" Font-Italic="True"></asp:TextBox>
                 &nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btnApply" runat="server" Height="49px" Text="Apply" Width="204px" OnClick="btnApply_Click" BackColor="#99CCFF" Font-Names="Akzidenz-Grotesk Pro Bold" Font-Bold="True" Font-Italic="True" />
                 <asp:Button ID="btnDisplayAll" runat="server" Height="49px" Text="Display All" Width="204px" OnClick="btnDisplayAll_Click" BackColor="#99CCFF" Font-Names="Akzidenz-Grotesk Pro Bold" Font-Bold="True" Font-Italic="True" />
                 &nbsp;&nbsp;&nbsp; 
        </div>
         <div style="margin-left: 1080px"></div>
        <div style="margin-left: 600px"><asp:Button ID="btnAdd" runat="server" Text="Add Customer" OnClick="btnAdd_Click" BackColor="#99CCFF" Font-Names="Akzidenz-Grotesk Pro Bold" Height="49px" Width="204px" Font-Bold="True" Font-Italic="True" /><asp:Button ID="btnEdit" runat="server" Text="Edit Details" OnClick="btnEdit_Click" BackColor="#99CCFF" Font-Names="Akzidenz-Grotesk Pro Bold" Height="49px" Width="204px" Font-Bold="True" Font-Italic="True" /><asp:Button ID="btnDelete" runat="server" Height="49px" Text="Delete" Width="204px" OnClick="btnDelete_Click" BackColor="#99CCFF" Font-Names="Akzidenz-Grotesk Pro Bold" Font-Bold="True" Font-Italic="True" />&nbsp;&nbsp;&nbsp; </div>
    </form>
</body>
</html>
