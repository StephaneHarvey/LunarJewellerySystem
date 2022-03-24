<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="98px" ImageUrl="~/StyleSheet/LunarJewelleryLogo.png" Width="98px" />
            <br />
            <br />
            <br />
            &nbsp;<asp:Label ID="lblStaffID" runat="server" Text="Staff ID" Font-Bold="True" Font-Names="Akzidenz-Grotesk Pro Cnd"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffID" runat="server" BackColor="#B9E6E0" BorderColor="#7DD2C6" BorderStyle="Outset"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnStaffFind" runat="server" Height="20px" OnClick="btnStaffFind_Click" style="margin-top: 0px" Text="Find" Font-Bold="True" Font-Names="Akzidenz-Grotesk Pro Light" />
        </div>
        <p>
&nbsp;<asp:Label ID="lblStaffFirstName" runat="server" Text="First Name" Font-Names="Akzidenz-Grotesk Pro Cnd"></asp:Label>
            &nbsp;<asp:TextBox ID="txtStaffFirstName" runat="server" BackColor="#DFF4F1"></asp:TextBox>
        </p>
        <p>
&nbsp;<asp:Label ID="lblStaffLastName" runat="server" Text="Last Name" Font-Names="Akzidenz-Grotesk Pro Cnd"></asp:Label>
            &nbsp;<asp:TextBox ID="txtStaffLastName" runat="server" BackColor="#DFF4F1"></asp:TextBox>
        </p>
        <p>
            &nbsp;
            <asp:Label ID="lblStaffDOB" runat="server" Text="Date of Birth" Font-Names="Akzidenz-Grotesk Pro Cnd"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffDOB" runat="server" BackColor="#DFF4F1"></asp:TextBox>
        </p>
        <p>
            &nbsp;
            <asp:Label ID="lblStaffContactNo" runat="server" Text="Contact No" Font-Names="Akzidenz-Grotesk Pro Cnd"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffContactNo" runat="server" BackColor="#DFF4F1"></asp:TextBox>
        </p>
        <p>
            &nbsp;
            <asp:Label ID="lblStaffAddress" runat="server" Text="Address" Font-Names="Akzidenz-Grotesk Pro Cnd"></asp:Label>

&nbsp;<asp:TextBox ID="txtStaffAddress" runat="server" BackColor="#DFF4F1"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="#CC0000" Font-Names="Akzidenz-Grotesk Pro Cnd"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Height="20px" Font-Bold="True" Font-Names="Akzidenz-Grotesk Pro Light" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" Height="21px" style="margin-top: 0px" Font-Bold="True" Font-Names="Akzidenz-Grotesk Pro Light" />
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>