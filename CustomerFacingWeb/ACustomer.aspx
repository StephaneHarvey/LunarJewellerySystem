<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 320px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <link href="StyleSheet/Customer.css" rel="stylesheet" />
        <br />
        <div style="margin-left: 880px">
            <asp:Image ID="Image1" runat="server" Height="138px" Width="157px" ImageUrl="~/StyleSheet/Lunar.png" />
        </div>
        <br />
        <br />
        <div style="text-align: center"><asp:Label ID="Label1" runat="server" Text="CustomerID" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="Aqua" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" Font-Size="Large"></asp:TextBox>
        <p class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="CustomerFirstName" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="Aqua" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="txtCustomerFirstName" runat="server" Font-Size="Large"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" Height="49px" Width="204px" BackColor="#66CCFF" Font-Bold="True" Font-Italic="True" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="White" />
        </p>
        <asp:Label ID="Label3" runat="server" Text="CustomerSurname" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="Aqua" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="txtCustomerSurname" runat="server" Font-Size="Large"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="CustomerDateAdded" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="Aqua" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="txtCustomerDateAdded" runat="server" Font-Size="Large"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server" Text="CustomerAddress" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="Aqua" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" Font-Size="Large"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="CustomerPostCode" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="Aqua" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" Font-Size="Large"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="CustomerEmail" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="Aqua" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" Font-Size="Large"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="CustomerMobileNumber" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="Aqua" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="txtMobileNumber" runat="server" Font-Size="Large"></asp:TextBox>
        <br />
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="Aqua" Font-Bold="True" Font-Italic="True" Font-Size="Large" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="Aqua" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Height="49px" Width="204px" BackColor="#66CCFF" Font-Bold="True" Font-Italic="True" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="White" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Height="49px" Width="204px" BackColor="#66CCFF" Font-Bold="True" Font-Italic="True" Font-Names="Akzidenz-Grotesk Pro Bold" ForeColor="White" OnClick="btnCancel_Click" />
       </div>
    </form>
</body>
</html>
