<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDefault.aspx.cs" Inherits="StaffDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
        </div>
            <div class="auto-style1">
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" Height="98px" ImageAlign="Top" ImageUrl="~/StyleSheet/LunarJewelleryLogo.png" Width="98px" style="text-align: center" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:ListBox ID="lstStaff" runat="server" BackColor="#DFF4F1" Height="299px" Width="530px" Font-Bold="True" Font-Names="Akzidenz-Grotesk Pro Light"></asp:ListBox>
            </div>
        <p class="auto-style1">
            <asp:Label ID="LblPlsFirstName" runat="server" Text="Please Enter a First Name" Font-Bold="True" Font-Names="Akzidenz-Grotesk Pro Regular"></asp:Label>
            :</p>
        
            <div class="auto-style1">
        
        <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
        
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Names="Akzidenz-Grotesk Pro Cnd"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" BackColor="#A2E1D8" Text="Apply" Width="100px" OnClick="btnApply_Click" Font-Bold="True" Font-Names="Akzidenz-Grotesk Pro Light" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDisplayAll" runat="server" BackColor="#A2E1D8" Text="Display All" Width="100px" OnClick="btnDisplayAll_Click" Font-Bold="True" Font-Names="Akzidenz-Grotesk Pro Light" />
        <br />
        <br />
        <br />
&nbsp;
        <asp:Button ID="btnAdd" runat="server" BackColor="#93E395" BorderColor="White" BorderStyle="Ridge" OnClick="btnAdd_Click" Text="Add" Width="63px" Font-Names="Akzidenz-Grotesk Pro Light" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" BackColor="#FAEC9A" BorderColor="White" BorderStyle="Ridge" Text="Edit" Width="63px" OnClick="btnEdit_Click" Font-Names="Akzidenz-Grotesk Pro Light" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" BackColor="#EA8C8A" BorderColor="White" BorderStyle="Ridge" Text="Delete" Width="63px" OnClick="btnDelete_Click" Font-Names="Akzidenz-Grotesk Pro Light" />
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
            </div>
        </div>
    </form>
</body>
</html>
