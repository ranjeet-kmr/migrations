<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DbMigration.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetDepartments" TypeName="DbMigration.DataRepo"></asp:ObjectDataSource>
            <br />
        </div>
    </form>
</body>
</html>
