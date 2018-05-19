Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.Web.ASPxGridView

Public Class CommandColumnHeaderTemplate
	Implements ITemplate
	Private gridView As ASPxGridView = Nothing
	Public Sub New(ByVal gridView As ASPxGridView)
		Me.gridView = gridView
	End Sub

	#Region "ITemplate Members"

	Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
		Dim checkBox As HtmlInputCheckBox = New HtmlInputCheckBox()
		container.Controls.Add(checkBox)
		checkBox.Attributes.Add("onclick", String.Format("{0}.SelectAllRowsOnPage(this.checked);", gridView.ClientID))
	End Sub

	#End Region
End Class
