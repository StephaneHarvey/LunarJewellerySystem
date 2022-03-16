<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDefault.aspx.cs" Inherits="OrderDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrders" runat="server" Height="315px" Width="433px"></asp:ListBox>
        <p>
            <asp:Label ID="lblOrderName" runat="server" Text="Please Enter Order Name "></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnApply" runat="server" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnAddOrder" runat="server" Text="Add Order" />
            <asp:Button ID="btnEditOrder" runat="server" Text="Edit Order" />
            <asp:Button ID="btnCancelOrder" runat="server" Text="Cancel Order" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
