<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RemoveFromGlobalOptOut.aspx.cs" Inherits="RemoveFromOptOut.RemoveFromGlobalOptOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            E-Mail Address: <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            Contact list ID: <asp:TextBox ID="ContactListId" runat="server"></asp:TextBox>
            <asp:Button ID="Remove" runat="server" Text="Remove From list" OnClick="Remove_Click" />
            <hr />
            <asp:Literal ID="StatusLiteral" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
