<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDefault.aspx.cs" Inherits="CustomerDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:ListBox ID="lstCustomers" runat="server" Height="383px" Width="496px"></asp:ListBox>
        <p>
            <asp:Label ID="lblPostCode" runat="server" Text="Please Enter a Post Code"></asp:Label>
        </p>
        <asp:TextBox ID="txtPostCode" runat="server" Height="26px" Width="258px"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" Height="35px" Text="Apply" Width="156px" />
            <asp:Button ID="btnDisplayAll" runat="server" Height="33px" Text="Display All" Width="158px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add Customer" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit Details" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Height="23px" Text="Delete" Width="92px" OnClick="btnDelete_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
