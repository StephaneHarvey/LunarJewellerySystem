<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="CustomerID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="CustomerFirstName"></asp:Label>
            <asp:TextBox ID="txtCustomerFirstName" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
        <asp:Label ID="Label3" runat="server" Text="CustomerSurname"></asp:Label>
        <asp:TextBox ID="txtCustomerSurname" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="CustomerDOB"></asp:Label>
            <asp:TextBox ID="txtCustomerDOB" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server" Text="CustomerAddress"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="CustomerPostCode"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="CustomerEmail"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="CustomerMobileNumber"></asp:Label>
        <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
