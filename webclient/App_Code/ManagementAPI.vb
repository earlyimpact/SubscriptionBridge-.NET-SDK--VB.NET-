Imports Microsoft.VisualBasic

Namespace SubscriptionBridge

    Public Class ManagementAPI

        Public Function AddMeteredRequest( _
                                            ByVal User As String, _
                                            ByVal Token As String, _
                                            ByVal Guid As String, _
                                            ByVal Amount As String, _
                                            ByVal Memo As String, _
                                            ByVal LinkID As String _
                                            ) As String

            Dim strXML As New StringBuilder

            strXML.AppendLine("<?xml version=""1.0"" encoding=""utf-8""?>")
            strXML.AppendLine("<AddMeteredRequest>")
            strXML.AppendLine("<Username>" & User & "</Username>")
            strXML.AppendLine("<Token>" & Token & "</Token>")
            strXML.AppendLine("<Guid>" & Guid & "</Guid>")
            strXML.AppendLine("<Amount>" & Utilities.removeInvalidXML(Amount) & "</Amount>")
            strXML.AppendLine("<Memo>" & Utilities.removeInvalidXML(Memo) & "</Memo>")
            strXML.AppendLine("<RefName>" & Utilities.removeInvalidXML(LinkID) & "</RefName>")
            strXML.AppendLine("</AddMeteredRequest>")

            Return strXML.ToString()

        End Function

    End Class

End Namespace
