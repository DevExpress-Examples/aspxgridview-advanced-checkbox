# OBSOLETE - How to create an Advanced Selection CheckBox at runtime


<p><strong>UPDATED:</strong><br /><br />Starting with version v2014 vol 1 (v14.1), this functionality is available out of the box. Simply set the <strong>GridViewCommandColumn.SelectAllCheckboxMode</strong> property to <strong>GridViewSelectAllCheckBoxMode.AllPages</strong> to activate it. Please refer to the <a href="https://community.devexpress.com/blogs/aspnet/archive/2014/05/28/asp-net-gridview-select-all-rows-updated-coming-soon-in-v14-1.aspx">ASP.NET: GridView Select All Rows Updated </a>blog post and the <a href="http://demos.devexpress.com/ASPxGridViewDemos/Selection/AdvancedSelection.aspx">Select All Rows</a> demo for more information.<br /><br />If you have version v14.1+ available, consider using the built-in functionality instead of the approach detailed below.<br />If you need further clarification, create a new ticket in our Support Center. <br /><br />This sample demonstrates how to create an advanced selection checkbox at runtime. To implement this, I have created a new class (CommandColumnHeaderTemplate). This class implements the ITemplate interface and contains the code to create the CheckBox shown in the CommandColumn's header.</p>

<br/>


