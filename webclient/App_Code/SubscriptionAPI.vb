Imports Microsoft.VisualBasic
Imports SubscriptionAPI

Namespace SubscriptionBridge

    Public Class SubscriptionAPI

        Public Function GetTimeRequest() As String

            Dim strXML As New StringBuilder

            strXML.AppendLine("<?xml version=""1.0"" encoding=""utf-8""?>")
            strXML.AppendLine("<GetTimeRequest>")
            strXML.AppendLine("<Username>" & "" & "</Username>")
            strXML.AppendLine("</GetTimeRequest>")

            Dim RequestXML As String
            RequestXML = strXML.ToString

            Dim XMLExchangeObj As New XMLExchange
            XMLExchangeObj.url = "https://www.subscriptionbridge.com/Subscriptions/Service2.svc/GetTimeRequest"

            Dim strResponse As String
            strResponse = XMLExchangeObj.sendXMLPOST(RequestXML)

            Return XMLExchangeObj.xEval(strResponse, "GetTimeResponse/CurrentTime")

            XMLExchangeObj = Nothing

        End Function

    End Class

End Namespace
