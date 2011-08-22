Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Diagnostics
Imports System.Text

Namespace SubscriptionBridge

    Public Class AuthenticationAPI

        Public Function VerifyAccountCredentialsRequest(ByVal User As String, ByVal Token As String, ByVal Email As String, ByVal Password As String) As String

            Dim strXML As New StringBuilder()

            strXML.AppendLine("<?xml version=""1.0"" encoding=""utf-8""?>")
            strXML.AppendLine("<VerifyAccountCredentialsRequest>")
            strXML.AppendLine("<Username>" & User & "</Username>")
            strXML.AppendLine("<Token>" & Token & "</Token>")
            strXML.AppendLine("<Email>" & Utilities.removeInvalidXML(Email) & "</Email>")
            strXML.AppendLine("<Password>" & Utilities.removeInvalidXML(Password) & "</Password>")
            strXML.AppendLine("</VerifyAccountCredentialsRequest>")

            Return strXML.ToString()

        End Function

        Public Function CheckAccountAvailableRequest(ByVal User As String, ByVal Token As String, ByVal Email As String) As String

            Dim strXML As New StringBuilder()

            strXML.AppendLine("<?xml version=""1.0"" encoding=""utf-8""?>")
            strXML.AppendLine("<CheckAccountAvailableRequest>")
            strXML.AppendLine("<Username>" & User & "</Username>")
            strXML.AppendLine("<Token>" & Token & "</Token>")
            strXML.AppendLine("<Email>" & Utilities.removeInvalidXML(Email) & "</Email>")
            strXML.AppendLine("</CheckAccountAvailableRequest>")

            Return strXML.ToString()

        End Function

        Public Function ModifyAccountCredentialsRequest(ByVal User As String, ByVal Token As String, ByVal Email As String, ByVal Password As String, ByVal NewPassword As String) As String

            Dim strXML As New StringBuilder()

            strXML.AppendLine("<?xml version=""1.0"" encoding=""utf-8""?>")
            strXML.AppendLine("<ModifyAccountCredentialsRequest>")
            strXML.AppendLine("<Username>" & User & "</Username>")
            strXML.AppendLine("<Token>" & Token & "</Token>")
            strXML.AppendLine("<Email>" & Utilities.removeInvalidXML(Email) & "</Email>")
            strXML.AppendLine("<Password>" & Utilities.removeInvalidXML(Password) & "</Password>")
            strXML.AppendLine("<NewPassword>" & Utilities.removeInvalidXML(NewPassword) & "</NewPassword>")
            strXML.AppendLine("</ModifyAccountCredentialsRequest>")

            Return strXML.ToString()

        End Function


    End Class

End Namespace
