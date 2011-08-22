<%@ Page Title="" Language="VB" MasterPageFile="~/UI.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>Kitchen Sink Demo</h1>

            <h2>Hosted Checkout</h2>
			<ul>
            	<li><a href="client.hcb.aspx" target="_blank">Subscribe Button</a></li>
                <li><a href="client.opc.aspx" target="_blank">Subscribe Button (OPC)</a></li>
                <li><a href="client.hcl.aspx">Subscribe Link</a></li>
                <li><a href="client.opc1.aspx">Subscribe Link (OPC)</a></li>
                <li><a href="client.hcpf.aspx" target="_blank">Pre-fill Checkout Form</a></li>
                <li>Checkout with Auto Login</li>
                <li><a href="client.hcru.aspx" target="_blank">Checkout w. Return URL</a></li>
                <li><a href="client.tw.aspx">Terms Widget (jQuery)</a></li>
                <li><a href="client.twp.aspx">Terms Widget (Prototype)</a></li>
            </ul>

            <h2>Authentication API</h2>
			<ul>
            	<li><a href="client.vac.aspx">Verify Account Credentials Request</a></li>
                <li><a href="client.caa.aspx">Check Account Available Request</a></li>
                <li><a href="client.mac.aspx">Modify Account Credentials Request</a></li>
            </ul>
            
            <h2>Management API</h2>
			<ul>
            	<li>Trial To Full (EIG)</li>
                <li>Update Subscription (EIG, PP, AUTH)</li>
                <li>Get Subscriptions Request</li>
                <li>Get Subscription Details Request</li>
                <li>Cancellation Request (EIG, PP, AUTH)</li>
                <li><a href="client.amr.aspx">Add Metered Request</a> (EIG)</li>
            </ul>
            
            <h2>Notification API</h2>
			<ul>
            	<li>Notification Request</li>
            </ul>
            
            <h2>Subscription API</h2>
			<ul>
            	<li>Create Subscription</li>
                <li>Get Terms</li>
                <li>Get Timestamp</li>
                <li>Activation Request</li>
                <li>Get Packages Request</li>
                <li>Get Features Request</li>
            </ul>

</asp:Content>

