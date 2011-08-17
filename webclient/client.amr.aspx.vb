Imports SubscriptionBridge
Imports SubscriptionAPI

Partial Class _client_amr
    Inherits BasePage

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim strMerchantUsername As String
        Dim strMerchantPassword As String
        Dim strMerchantKey As String

        strMerchantUsername = _User.Text
        strMerchantPassword = _Pass.Text
        strMerchantKey = _Key.Text

        '// Hash the Token
        Dim strToken As String = Utilities.HashToken(strMerchantPassword, strMerchantKey)

        '// Form
        Dim strGuid As String = Guid.text
        Dim strAmount As String = Amount.Text
        Dim strMemo As String = Memo.Text
        Dim strLinkID As String = LinkID.Text


        Dim ManagementAPIObj As New ManagementAPI
        Dim RequestXML As String
        RequestXML = ManagementAPIObj.AddMeteredRequest( _
                                            strMerchantUsername, _
                                            strToken, _
                                            strGuid, _
                                            strAmount, _
                                            strMemo, _
                                            strLinkID _
                                            )
        ManagementAPIObj = Nothing

        Dim XMLExchangeObj As New XMLExchange
        XMLExchangeObj.url = "https://www.subscriptionbridge.com/Management/Service3.svc/AddMeteredRequest"

        Dim strResponse As String
        strResponse = XMLExchangeObj.sendXMLPOST(RequestXML)
        XMLExchangeObj = Nothing


        If InStr(strResponse, "Success") Then

            'Dim strParam As String
            'strParam = XMLExchangeObj.xEval(strResponse, "AddMeteredResponse/Ack")
            'Results.Text = strParam

            Results.Text = strResponse

        Else

            Results.Text = strResponse

        End If


    End Sub


End Class
