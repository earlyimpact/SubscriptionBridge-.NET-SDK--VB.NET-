Imports Microsoft.VisualBasic
Imports System.Threading
Imports System.Globalization

Namespace SubscriptionBridge

    ''' <summary>
    ''' Custom base page used for all web forms.
    ''' </summary>
    Public Class BasePage
        Inherits System.Web.UI.Page


        Protected Overrides Sub OnError(ByVal e As System.EventArgs)

            '// Redirect to Generic Error
            Response.Redirect("/500.aspx", False)

        End Sub

    End Class

End Namespace