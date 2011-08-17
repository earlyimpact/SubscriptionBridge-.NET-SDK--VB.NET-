Imports Microsoft.VisualBasic
Imports System.Globalization

Namespace SubscriptionBridge

    Public Class Utilities

        Public Shared known_bad As String() = {"*", "--", ";--", ";", "/*", "*/", "@@", _
                                               "char", "nchar", "varchar", "nvarchar", "alter", _
                                               "begin", "create", "cursor", "declare", "delete", _
                                               "drop", "exec", "execute", "fetch", "insert", _
                                               "kill", "open", "select", "sys", "sysobjects", "syscolumns", _
                                               "table", "update", ")", "(", "|", ""}

        Public Function GetUserInput(ByVal UserInput As String, ByVal stringLength As Integer) As String

            Dim tempStr As String = ""
            Dim i As Integer = 0

            If stringLength > 0 Then
                tempStr = Left(Trim(UserInput), stringLength)
            Else
                tempStr = Trim(UserInput)
            End If

            If String.IsNullOrEmpty(tempStr) Then
                Return ""
                Exit Function
            End If

            For i = 0 To known_bad.Length - 1
                If (UserInput.IndexOf(known_bad(i), StringComparison.OrdinalIgnoreCase) >= 0) Then
                    tempStr = Replace(tempStr, known_bad(i), "")
                End If
            Next

            tempStr = Replace(tempStr, "%0d", "")
            tempStr = Replace(tempStr, "%0D", "")
            tempStr = Replace(tempStr, "%0a", "")
            tempStr = Replace(tempStr, "%0A", "")
            tempStr = Replace(tempStr, "\r\n", "")
            tempStr = Replace(tempStr, "\r", "")
            tempStr = Replace(tempStr, "\n", "")
            tempStr = Replace(tempStr, "\R\N", "")
            tempStr = Replace(tempStr, "\R", "")
            tempStr = Replace(tempStr, "\N", "")
            tempStr = Replace(tempStr, "EXEC(", "", 1, -1, 1)

            UserInput = tempStr

            Return UserInput

        End Function


        Public Shared Function removeInvalidXML(ByVal element As String) As String
            element = Replace(element, "&", " and ")
            Return element
        End Function


        Public Shared Function HashToken(ByRef Password As String, ByRef Key As String) As String

            Dim Token As String

            '// Timestamp
            'Dim dt As DateTime = DateTime.Now.ToLocalTime()
            'Dim minute As New System.TimeSpan(0, 0, 0, 0, 0)
            'dt = dt - minute
            ' dt = dt.ToString("yyyy-MM-ddTHH:mm:00", CultureInfo.CreateSpecificCulture("en-US"))

            Dim SubscriptionAPIObj As New SubscriptionAPI
            Dim dt As String = SubscriptionAPIObj.GetTimeRequest()

            '// Password Digest
            '   -> PassWord|YYYYMMDD|HHMM
            Token = Password & "|" & dt
            Token = hex_hmac_sha1(Key, Token)

            Return Token

        End Function


        Public Shared Function hex_hmac_sha1(ByVal key As String, ByVal to_hash As String) As String

            Dim hmac As New System.Security.Cryptography.HMACSHA1
            hmac.Key = System.Text.Encoding.ASCII.GetBytes(key)
            hmac.ComputeHash(System.Text.Encoding.ASCII.GetBytes(DirectCast(to_hash, String)))


            Dim _h As String = ""
            For Each num As Byte In hmac.Hash
                _h += num.ToString("X02")
            Next

            Return _h

        End Function


    End Class


End Namespace