<%-- BeginRegion TagPrefix and page properties --%>
<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="Advanced_CheckBox_Selection" ValidateRequest="false"%>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v7.3" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v7.3" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%-- EndRegion --%>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>How to create an Advanced Selection CheckBox at runtime</title>
</head>
<body>
	<form id="form1" runat="server">

	<dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False"
			DataSourceID="AccessDataSource1" KeyFieldName="OrderID">
			<Columns>
				<dxwgv:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0">
				</dxwgv:GridViewCommandColumn>
				<dxwgv:GridViewDataTextColumn FieldName="OrderID" ReadOnly="True" VisibleIndex="1">
					<EditFormSettings Visible="False" />
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="CustomerID" VisibleIndex="2">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="EmployeeID" VisibleIndex="3">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataDateColumn FieldName="OrderDate" VisibleIndex="4">
				</dxwgv:GridViewDataDateColumn>
				<dxwgv:GridViewDataDateColumn FieldName="RequiredDate" VisibleIndex="5">
				</dxwgv:GridViewDataDateColumn>
				<dxwgv:GridViewDataDateColumn FieldName="ShippedDate" VisibleIndex="6">
				</dxwgv:GridViewDataDateColumn>
				<dxwgv:GridViewDataTextColumn FieldName="ShipVia" VisibleIndex="7">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="Freight" VisibleIndex="8">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="ShipName" VisibleIndex="9">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="ShipAddress" VisibleIndex="10">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="ShipCity" VisibleIndex="11">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="ShipRegion" VisibleIndex="12">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="ShipPostalCode" VisibleIndex="13">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="ShipCountry" VisibleIndex="14">
				</dxwgv:GridViewDataTextColumn>
			</Columns>
			<Settings ShowGroupPanel="True" ShowFilterRow="True" ShowVerticalScrollBar="True" />
			<SettingsEditing Mode="PopupEditForm" />
		</dxwgv:ASPxGridView>
		<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
			SelectCommand="SELECT * FROM [Orders]">
		</asp:AccessDataSource>
	</form>
</body>
</html>