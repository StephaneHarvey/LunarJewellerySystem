<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDefault.aspx.cs" Inherits="StockDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStock" runat="server" Height="194px" Width="347px"></asp:ListBox>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
        <asp:Label ID="lblStockItem" runat="server" Text="Please Type Stock Item"></asp:Label>
        <p>
            <asp:TextBox ID="txtStockItem" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnApply" runat="server" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </p>
    </form>
</body>
</html>
