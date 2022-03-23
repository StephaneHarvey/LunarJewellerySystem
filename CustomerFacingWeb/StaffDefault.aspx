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
        <br />
        <asp:Image ID="Image1" runat="server" Height="98px" ImageAlign="Top" ImageUrl="~/StyleSheet/LunarJewelleryLogo.png" Width="96px" />
        <br />
        <br />
        <asp:ListBox ID="lstStaff" runat="server" BackColor="#DFF4F1" Height="299px" Width="482px"></asp:ListBox>
        <p>
            <asp:Label ID="LblPlsFirstName" runat="server" Text="Please Enter a First Name"></asp:Label>
        </p>
        
        <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
        
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" BackColor="#A2E1D8" Text="Apply" Width="100px" OnClick="btnApply_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDisplayAll" runat="server" BackColor="#A2E1D8" Text="Display All" Width="100px" OnClick="btnDisplayAll_Click" />
        <br />
        <br />
        <br />
&nbsp;
        <asp:Button ID="btnAdd" runat="server" BackColor="#93E395" BorderColor="White" BorderStyle="Ridge" OnClick="btnAdd_Click" Text="Add" Width="63px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" BackColor="#FAEC9A" BorderColor="White" BorderStyle="Ridge" Text="Edit" Width="63px" OnClick="btnEdit_Click" />
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
