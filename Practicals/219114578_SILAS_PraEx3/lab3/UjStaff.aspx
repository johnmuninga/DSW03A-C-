<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UjStaff.aspx.cs" Inherits="lab3.UjStaff" %>

<!DOCTYPE html>
<script runat="server">





    protected void BtnRead_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Image ID="Image2" runat="server" Width="122px" />
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="UJ Staff Portal"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Id Number"></asp:Label>
            <asp:TextBox ID="TxtID" runat="server" OnTextChanged="TxtID_TextChanged"></asp:TextBox>
            <asp:Button ID="BtnCreate" runat="server" OnClick="BtnCreate_Click" Text="Create" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TxtName" runat="server" OnTextChanged="TxtName_TextChanged"></asp:TextBox>
            <asp:Button ID="BtnSave" runat="server" Text="Save" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Surname"></asp:Label>
            <asp:TextBox ID="TxtSurname" runat="server" Height="16px" OnTextChanged="TxtSurname_TextChanged"></asp:TextBox>
            <asp:Button ID="BtnRead" runat="server" Text="Read" OnClick="BtnRead_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TxtEmail" runat="server" OnTextChanged="TxtEmail_TextChanged"></asp:TextBox>
            <asp:Button ID="BtnClear" runat="server" Text="Clear" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Age"></asp:Label>
            <asp:TextBox ID="TxtAge" runat="server" OnTextChanged="TxtAge_TextChanged"></asp:TextBox>
            <asp:Button ID="BtnExit" runat="server" Text="Exit" />
        </p>
    </form>
</body>
</html>
