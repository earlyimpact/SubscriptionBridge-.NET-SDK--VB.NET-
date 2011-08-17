<%@ Page Title="" Language="VB" MasterPageFile="~/UI.master" AutoEventWireup="false" CodeFile="client.hcal.aspx.vb" Inherits="_client_hcal" %>

<%@ Import Namespace="SubscriptionBridge" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <h1>Checkout with Auto Login</h1>


    <p>Please view source and replace &quot;merchant_key&quot; and &quot;password&quot; with real values before you run this demo.</p>

    <br />

<%
    Dim token As String = ""
    token = Utilities.HashToken("merchant_key", "password") '// merchant key / password
%>

<!-- Add params as hidden fields -->
<input name="start_page" type="hidden" value="payment" /> 
<input name="first_name" type="hidden" value="Matt" />
<input name="last_name" type="hidden" value="Weber" />
<input name="company" type="hidden" value="Early Impact, Inc." />
<input name="email" type="hidden" value="mweber@earlyimpact.com" />
<input name="token" type="hidden" value="<%=token%>" />

<a href="javascript:theForm.__VIEWSTATE.value='';
            theForm.encoding='application/x-www-form-urlencoded';
            theForm.action='https://www.subscriptionbridge.com/checkout/SimpleEIGTest1';
            theForm.submit();"><img src="https://www.paypal.com/en_US/i/btn/btn_subscribe_LG.gif" border="0" alt="Subscribe" /></a>

</asp:Content>

