<%@ Page Title="" Language="VB" MasterPageFile="~/UI.master" AutoEventWireup="false" CodeFile="client.opc.aspx.vb" Inherits="_client_opc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>Subscribe Button (OPC)</h1>


<!-- Add params as hidden fields -->
<input name="start_page" type="hidden" value="payment" />

<a href="javascript:theForm.__VIEWSTATE.value='';
            theForm.encoding='application/x-www-form-urlencoded';
            theForm.action='https://www.subscriptionbridge.com/checkout/SBMerchantAcc';
            theForm.submit();"><img src="https://www.paypal.com/en_US/i/btn/btn_subscribe_LG.gif" border="0" alt="Subscribe" /></a>



</asp:Content>

