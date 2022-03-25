<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;<asp:ImageButton ID="ImageBtnStaff" runat="server" BorderColor="#7DD2C6" BorderStyle="Outset" BorderWidth="8px" Height="400px" ImageUrl="~/StyleSheet/StaffIcon.jpg" OnClick="ImageBtnStaff_Click" Width="280px" />
&nbsp;&nbsp;
            <asp:ImageButton ID="ImgBtnCustomer" runat="server" BorderColor="#7DD2C6" BorderStyle="Outset" BorderWidth="8px" Height="400px" ImageUrl="~/StyleSheet/CustomerIcon.jpg" OnClick="ImgBtnCustomer_Click" Width="280px" />
&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImgBtnInventory" runat="server" BorderColor="#7DD2C6" BorderStyle="Outset" BorderWidth="8px" Height="400px" ImageUrl="~/StyleSheet/StockIcon.jpg" OnClick="ImgBtnInventory_Click" Width="279px" />
&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImgBtnOrder" runat="server" BackColor="#7DD2C6" BorderColor="#7DD2C6" BorderStyle="Outset" BorderWidth="8px" Height="400px" ImageUrl="~/StyleSheet/OrderIcon.jpg" OnClick="ImgBtnOrder_Click" Width="279px" />
        </p>
    </form>
</body>
</html>
