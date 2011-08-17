Imports System
Imports System.Net
Imports System.Web
Imports System.Xml
Imports System.IO

Namespace SubscriptionAPI


    Public Class XMLExchange

        Private APIurl As String
        Private ProxyString As String
        Private RequestObject As HttpWebRequest
        Private ResponseObject As HttpWebResponse

        Public Property proxy() As String
            Get
                Return Me.ProxyString
            End Get
            Set(ByVal value As String)
                Me.ProxyString = value
            End Set
        End Property

        Public Property url() As String
            Get
                Return Me.APIurl
            End Get
            Set(ByVal value As String)
                Me.APIurl = value
            End Set
        End Property

        Public Sub New()
            Me.ProxyString = ""
            Me.APIurl = ""
        End Sub

        Public Shared Function CheckXMLSuccess(ByVal xtr As XmlTextReader) As Boolean
            Dim flag1 As Boolean = False
            xtr.WhitespaceHandling = WhitespaceHandling.None
            While xtr.Read()
                If xtr.Name <> "SUCCESS" Then
                    Continue While
                End If
                Try
                    flag1 = Convert.ToBoolean(xtr.ReadString())
                Catch generatedExceptionName As Exception
                End Try
                Exit While
            End While
            Return flag1
        End Function

        Public Function sendXML(ByVal XMLtoSend As String) As XmlTextReader
            Dim reader1 As XmlTextReader = Nothing
            Dim text1 As String = (Me.APIurl & "?xml=") + HttpUtility.UrlEncode(XMLtoSend)
            Me.RequestObject = DirectCast(WebRequest.Create(text1), HttpWebRequest)
            Me.RequestObject.Accept = "text/xml"
            Me.RequestObject.ContentType = "application/x-www-form-urlencoded"
            Me.RequestObject.Method = "POST"
            Me.RequestObject.Timeout = 10000
            'Me.RequestObject.Proxy = New WebProxy(Me.ProxyString)
            Try
                Me.ResponseObject = DirectCast(Me.RequestObject.GetResponse(), HttpWebResponse)
                reader1 = New XmlTextReader(Me.ResponseObject.GetResponseStream())
            Catch exception1 As Exception
                Dim exception2 As New WebException((exception1.Message & " (proxy is: ") + Me.ProxyString & ")")
                Throw exception2
            End Try
            Return reader1
        End Function


        Public Function sendXMLPOST(ByVal XMLtoSend As String) As String

            Dim result As String = ""
            Dim myWriter As StreamWriter

            RequestObject = DirectCast(WebRequest.Create(APIurl), HttpWebRequest)
            RequestObject.Accept = "text/xml"
            RequestObject.ContentType = "text/xml"
            RequestObject.Method = "POST"
            RequestObject.Timeout = 30000

            Try

                myWriter = New StreamWriter(RequestObject.GetRequestStream())
                myWriter.Write(XMLtoSend)
                myWriter.Flush()
                myWriter.Close()

                Dim objResponse As HttpWebResponse = RequestObject.GetResponse()
                Dim sr As StreamReader
                sr = New StreamReader(objResponse.GetResponseStream())
                result = sr.ReadToEnd()
                sr.Close()

            Catch e1 As Exception

                result = e1.Message

            Finally

                RequestObject = Nothing

            End Try

            Return result

            RequestObject = Nothing
            myWriter = Nothing

        End Function


        Public Function xEval(ByVal x As String, ByVal xPath As String) As String
            Dim xDocument As New XmlDocument
            xDocument.LoadXml(x)
            If xDocument.SelectSingleNode(xPath) Is Nothing Then
                x = ""
            Else
                x = xDocument.SelectSingleNode(xPath).InnerText
            End If
            Return x
        End Function


    End Class


End Namespace
