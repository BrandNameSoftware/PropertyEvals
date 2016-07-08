<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchParams.aspx.cs" Inherits="PropertyEval.SearchParams" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblInput" runat="server" Text="Input"></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="TxtStreetAddresses" runat="server" Height="251px" Rows="15" TextMode="MultiLine" Width="482px"></asp:TextBox>
        <asp:Button ID="BtnSearch" runat="server" OnClick="BtnSearch_Click" Text="Search" />
    </div>
        
    <div>
        <asp:Label ID="lblOutput" runat="server" Text="Output"></asp:Label>
    </div>
    <div>
        <asp:GridView ID="GridViewResults" runat="server"></asp:GridView>
    </div>
    </form>
    
</body>
</html>
