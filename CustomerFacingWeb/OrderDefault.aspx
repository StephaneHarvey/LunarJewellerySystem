<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDefault.aspx.cs" Inherits="OrderDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Image ID="lunarlogo" runat="server" ImageUrl="~/StyleSheet/LunarJewelleryLogo.png" Height="122px" Width="121px" />
        </div>
        <asp:ListBox ID="lstOrders" runat="server" Height="315px" Width="433px" BackColor="#D1EFF1">
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        <p>
            <asp:Label ID="lblOrderName" runat="server" Text="Please Enter Product Number"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtProductNo" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnApply" runat="server" Text="Apply" BackColor="#ACF7E8" OnClick="btnApply_Click" style="height: 26px" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" BackColor="#ACF7E8" OnClick="btnDisplayAll_Click" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnAddOrder" runat="server" Text="Add Order" OnClick="btnAddOrder_Click" BackColor="#ACF7E8" />
            <asp:Button ID="btnEditOrder" runat="server" Text="Edit Order" OnClick="btnEditOrder_Click" BackColor="#ACF7E8" />
            <asp:Button ID="btnCancelOrder" runat="server" Text="Cancel Order" OnClick="btnCancelOrder_Click" BackColor="#ACF7E8" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
