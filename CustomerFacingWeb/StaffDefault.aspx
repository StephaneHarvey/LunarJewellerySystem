<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDefault.aspx.cs" Inherits="StaffDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaff" runat="server" BackColor="#CADDEC" Height="299px" Width="482px"></asp:ListBox>
        <p>
            <asp:Label ID="LblPlsFirstName" runat="server" Text="Please Enter a First Name"></asp:Label>
        </p>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" BackColor="#A0C2DE" Text="Apply" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDisplayAll" runat="server" BackColor="#A0C2DE" Text="Display All" Width="100px" />
        <br />
        <br />
        <br />
&nbsp;
        <asp:Button ID="btnAdd" runat="server" BackColor="#93E395" BorderColor="White" BorderStyle="Ridge" OnClick="btnAdd_Click" Text="Add" Width="63px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" BackColor="#FAEC9A" BorderColor="White" BorderStyle="Ridge" Text="Edit" Width="63px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" BackColor="#EA8C8A" BorderColor="White" BorderStyle="Ridge" Text="Delete" Width="63px" OnClick="btnDelete_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
