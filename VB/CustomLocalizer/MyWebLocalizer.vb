Imports DevExpress.Web.ASPxClasses.Localization
Imports DevExpress.Utils.Localization.Internal

Namespace CustomLocalizer

    Public Class MyWebLocalizer
        Inherits ASPxperienceLocalizer

        Public Shared Sub Activate()
            Dim localizer As New MyWebLocalizer()
            Dim provider As DefaultActiveLocalizerProvider(Of ASPxperienceStringId) = _
                New DefaultActiveLocalizerProvider(Of ASPxperienceStringId)(localizer)
            MyWebLocalizer.SetActiveLocalizerProvider(provider)
        End Sub

        Public Overrides Function GetLocalizedString(ByVal id As ASPxperienceStringId) As String
            Dim result As String = MyBase.GetLocalizedString(id)
            Return String.Format("web:{0}", result)
        End Function

    End Class

End Namespace
