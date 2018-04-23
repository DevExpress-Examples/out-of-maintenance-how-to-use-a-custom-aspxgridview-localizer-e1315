Imports System
Imports System.Data


Namespace CustomLocalizer
    Partial Public Class _Default
        Inherits System.Web.UI.Page

        Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
            ASPxGridView1.DataSource = GetDemoData()
        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxGridView1.DataBind()
        End Sub

        Private Function GetDemoData() As DataTable
            Dim table As New DataTable()
            table.Columns.Add("ID", GetType(Integer))
            table.Rows.Add(1)
            Return table
        End Function

        Protected Sub ASPxGridView1_RowInserting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertingEventArgs)
            CancelEditing(e)
        End Sub
        Protected Sub ASPxGridView1_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs)
            CancelEditing(e)
        End Sub
        Protected Sub ASPxGridView1_RowDeleting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataDeletingEventArgs)
            CancelEditing(e)
        End Sub

        Private Sub CancelEditing(ByVal e As System.ComponentModel.CancelEventArgs)
            e.Cancel = True
            ASPxGridView1.CancelEdit()
        End Sub

    End Class

End Namespace
