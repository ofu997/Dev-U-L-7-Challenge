<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DevUL7ChallengeForm.aspx.cs" Inherits="DevUL7Challenge.DevUL7ChallengeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator<br />
            <br />
            Width&nbsp;
            <asp:TextBox ID="wTextBox" runat="server" AutoPostBack="True" OnTextChanged="wTextBox_TextChanged"></asp:TextBox>
            <br />
            Height&nbsp;
            <asp:TextBox ID="hTextBox" runat="server" AutoPostBack="True" OnTextChanged="hTextBox_TextChanged"></asp:TextBox>
            <br />
            Length&nbsp;
            <asp:TextBox ID="lTextBox" runat="server" AutoPostBack="True" OnTextChanged="lTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundRadioButton" runat="server" OnCheckedChanged="groundRadioButton_CheckedChanged" Text="Ground" AutoPostBack="True" GroupName="methodGroup" />
            <br />
            <asp:RadioButton ID="airRadioButton" runat="server" OnCheckedChanged="airRadioButton_CheckedChanged" Text="Air" AutoPostBack="True" GroupName="methodGroup" />
            <br />
            <asp:RadioButton ID="nextDayRadioButton" runat="server" OnCheckedChanged="nextDayRadioButton_CheckedChanged" Text="Next Day" AutoPostBack="True" GroupName="methodGroup" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
