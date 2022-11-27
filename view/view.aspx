<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="view.view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Design.css" rel="stylesheet" />


</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="inputlabel" runat="server" Text="CategoryName: "></asp:Label> 
            <asp:TextBox ID="Txt_input" runat="server"></asp:TextBox>
            <asp:Button ID="result" runat="server" Text="Search" OnClick="result_Click" />
            <br />
            <asp:Label ID="result_label" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridShow" class="gird" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
