Imports DevExpress.Web.Localization
Imports DevExpress.Utils.Localization.Internal

Namespace CustomLocalizer

    Public Class MyEditorsLocalizer
        Inherits ASPxEditorsLocalizer

        Public Shared Sub Activate()
            Dim localizer As New MyEditorsLocalizer()
            Dim provider As DefaultActiveLocalizerProvider(Of ASPxEditorsStringId) = _
                New DefaultActiveLocalizerProvider(Of ASPxEditorsStringId)(localizer)
            MyEditorsLocalizer.SetActiveLocalizerProvider(provider)
        End Sub

        Public Overrides Function GetLocalizedString(ByVal id As ASPxEditorsStringId) As String
            Dim result As String = MyBase.GetLocalizedString(id)
            Return String.Format("editors:{0}", result)
        End Function

    End Class

End Namespace
