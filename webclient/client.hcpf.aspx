<%@ Page Title="" Language="VB" MasterPageFile="~/UI.master" AutoEventWireup="false" CodeFile="client.hcpf.aspx.vb" Inherits="_client_hcpf" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>Pre-fill Checkout Form</h1>

<!-- Add params as hidden fields -->
<input name="start_page" type="hidden" value="payment" /> 
<input name="first_name" type="hidden" value="Matt" />
<input name="last_name" type="hidden" value="Weber" />
<input name="company" type="hidden" value="Early Impact, Inc." />
<input name="email" type="hidden" value="mweber@earlyimpact.com" />
<input name="reference" type="hidden" value="customerID" />

<a href="javascript:theForm.__VIEWSTATE.value='';
            theForm.encoding='application/x-www-form-urlencoded';
            theForm.action='https://www.subscriptionbridge.com/checkout/SBMerchantAcc';
            theForm.submit();"><img src="https://www.paypal.com/en_US/i/btn/btn_subscribe_LG.gif" border="0" alt="Subscribe" /></a>

</asp:Content>

