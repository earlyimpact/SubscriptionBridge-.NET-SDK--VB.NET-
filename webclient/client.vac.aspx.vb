Imports SubscriptionBridge
Imports SubscriptionAPI

Partial Class _client_vac
    Inherits BasePage

    Protected Sub Button1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim strMerchantUsername As String
        Dim strMerchantPassword As String
        Dim strMerchantKey As String

        strMerchantUsername = _User.Text
        strMerchantPassword = _Pass.Text
        strMerchantKey = _Key.Text

        '// Hash the Token
        Dim strToken As String = Utilities.HashToken(strMerchantPassword, strMerchantKey)

        '// Form
        Dim strEmail As String = Email.Text
        Dim strPassword As String = Password.Text


        Dim AuthenticationAPIObj As New AuthenticationAPI
        Dim RequestXML As String
        RequestXML = AuthenticationAPIObj.VerifyAccountCredentialsRequest(strMerchantUsername, strToken, strEmail, strPassword)
        AuthenticationAPIObj = Nothing

        Dim XMLExchangeObj As New XMLExchange
        XMLExchangeObj.url = "https://www.subscriptionbridge.com/Authentication/Service5.svc/VerifyAccountCredentialsRequest"

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
