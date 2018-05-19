Imports System
Imports System.Web.UI

Partial Public Class Advanced_CheckBox_Selection
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        ASPxGridView1.Columns(0).HeaderTemplate = New CommandColumnHeaderTemplate(ASPxGridView1)
    End Sub
End Class
