Imports System


Namespace CustomLocalizer
    Public Class [Global]
        Inherits System.Web.HttpApplication

        Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
            MyWebLocalizer.Activate()
            MyEditorsLocalizer.Activate()
            MyGridLocalizer.Activate()
        End Sub

    End Class

End Namespace