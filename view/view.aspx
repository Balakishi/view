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
            <asp:TextBox ID="Txt_input" runat="server" OnTextChanged="Txt_input_TextChanged"></asp:TextBox>
            <asp:Button ID="result" runat="server" Text="Search" OnClick="result_Click" />
            <br />
            <asp:Label ID="result_label" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridShow" class="gird" runat="server" AllowPaging="true" PageSize="5" OnPageIndexChanging="GridShow_PageIndexChanging" >
                <PagerSettings FirstPageText="&quot;First&quot;" LastPageImageUrl="&quot;Last&quot;" Mode="NumericFirstLast" PageButtonCount="4" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
