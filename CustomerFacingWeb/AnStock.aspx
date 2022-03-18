<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnStock.aspx.cs" Inherits="AnStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="StockItem"></asp:Label>
        <asp:TextBox ID="txtStockItem" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="StockQuantity"></asp:Label>
            <asp:TextBox ID="txtStockQuantity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="StockDate"></asp:Label>
            <asp:TextBox ID="txtStockDate" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <p>
            <asp:Button ID="btnOk" runat="server" style="margin-bottom: 0px; width: 31px;" Text="Ok" OnClick="btnOk_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
