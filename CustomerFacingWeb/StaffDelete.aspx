<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDelete.aspx.cs" Inherits="StaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 364px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblConfirmStaffDelete" runat="server" Text="Are you sure you want to delete this staff member?"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnYesDelete" runat="server" OnClick="btnYesDelete_Click" Text="Yes" Width="63px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancelDelete" runat="server" Text="Cancel" Width="62px" />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
