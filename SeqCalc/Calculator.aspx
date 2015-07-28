<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="SeqCalc.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table data-toggle="table" data-cache="false" data-height="299">
    <thead>
        <tr>
            <td data-field="lblText">
                <asp:label runat="server" text="Input"></asp:label>
            </td>
            <td data-field="inputText">
                <asp:textbox runat="server" id="input"></asp:textbox>
            </td>
        </tr>
        <tr>
            <td><asp:button runat="server" text="Get Sequences" OnClick="Unnamed2_Click" /></td>
        </tr>
    </thead>
</table>
    <asp:Literal ID="ltrResult" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
