<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderNo" runat="server" Text="OrderNo"></asp:Label>
            <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
            <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
        <p>
            <asp:Label ID="lblOrderName" runat="server" Text="Order Name"></asp:Label>
            <asp:TextBox ID="txtOrderName" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblProductNo" runat="server" Text="Product No"></asp:Label>
            <asp:TextBox ID="txtProductNo" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" style="height: 26px" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
