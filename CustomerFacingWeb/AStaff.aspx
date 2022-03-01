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
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
        </div>
        <p>
&nbsp;<asp:Label ID="lblStaffFirstName" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtStaffFirstName" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;<asp:Label ID="lblStaffLastName" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtStaffLastName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffDOB" runat="server" Text="Date of Birth"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffDOB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffContactNo" runat="server" Text="Contact No"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffContactNo" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffAddress" runat="server" Text="Address"></asp:Label>

&nbsp;<asp:TextBox ID="txtStaffAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="#CC0000"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
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