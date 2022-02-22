<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblStatusNo" runat="server" Text="Status No"></asp:Label>
            <asp:TextBox ID="txtStatusNo" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblProductType" runat="server" Text="Product Type"></asp:Label>
        <asp:TextBox ID="txtProductType" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblProduct" runat="server" Text="Product"></asp:Label>
            <asp:TextBox ID="txtProduct" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblOrderName" runat="server" Text="Order Name"></asp:Label>
            <asp:TextBox ID="txtOrderName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblProductNo" runat="server" Text="Product No"></asp:Label>
            <asp:DropDownList ID="dpdProductNo" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="Active" runat="server" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
