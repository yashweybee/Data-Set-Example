<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Data_Set_Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" ForeColor="White">
                <EditRowStyle BackColor="#3333FF" />
                <HeaderStyle BackColor="#3366FF" BorderColor="White" BorderStyle="Solid" />
                <RowStyle BackColor="#33CCFF" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
