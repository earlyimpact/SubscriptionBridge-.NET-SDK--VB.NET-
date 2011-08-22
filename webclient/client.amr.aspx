<%@ Page Title="" validateRequest="false" Language="VB" MasterPageFile="~/UI.master" AutoEventWireup="false" CodeFile="client.amr.aspx.vb" Inherits="_client_amr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>Add Metered Charge</h1>

    <p>Note:  API credentials should be hidden in code behind for production apps</p>

    <table width="100%" border="0" cellpadding="2" cellspacing="2">
        <tr>
            <td colspan="2"><h2>Credentials</h2></td>
        </tr>
        <tr>
            <td class="leftCell" nowrap="nowrap">Username:  </td>
            <td>
                <asp:TextBox ID="_User" class="sbInputField" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="leftCell" nowrap="nowrap">Password:  </td>
            <td>
                <asp:TextBox ID="_Pass" class="sbInputField" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="leftCell" nowrap="nowrap">API Key: </td>
            <td>
                <asp:TextBox ID="_Key" class="sbInputField" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2"><h2>Subscription</h2></td>
        </tr> 
        <tr>
            <td class="leftCell" nowrap="nowrap">Guid: </td>
            <td>
                <asp:TextBox ID="Guid" class="sbInputField" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2"><h2>Metered</h2></td>
        </tr>
        <tr>
            <td class="leftCell" nowrap="nowrap">Amount: </td>
            <td>
                <asp:TextBox ID="Amount" class="sbInputField" runat="server">5.00</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="leftCell" nowrap="nowrap">Meter Reference ID: </td>
            <td>
                <asp:TextBox ID="LinkID" class="sbInputField" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="leftCell" nowrap="nowrap">Memo: </td>
            <td>
                <asp:TextBox ID="Memo" class="sbInputField" runat="server" Height="126px" Width="305px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Submit" class="sbFormButton" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2"><h2>Reply</h2></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="Results" class="sbInputField" runat="server" Height="126px" Width="305px"></asp:TextBox>
            </td>
        </tr>
    </table>

</asp:Content>

