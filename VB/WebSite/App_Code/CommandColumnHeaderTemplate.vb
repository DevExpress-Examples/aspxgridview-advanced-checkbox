Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView

Public Class CommandColumnHeaderTemplate
    Implements ITemplate

    Private gridView As ASPxGridView = Nothing

    Public Sub New(ByVal gridView As ASPxGridView)
        Me.gridView = gridView
    End Sub

    #Region "ITemplate Members"

    Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
        Dim checkBox As New HtmlInputCheckBox()
        container.Controls.Add(checkBox)
        checkBox.Attributes.Add("onclick", String.Format("{0}.SelectAllRowsOnPage(this.checked);", gridView.ClientInstanceName))
    End Sub

    #End Region
End Class
