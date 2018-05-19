using System;
using System.Web.UI;

public partial class Advanced_CheckBox_Selection : Page {
    protected void Page_Load(object sender, EventArgs e) {
        ASPxGridView1.Columns[0].HeaderTemplate = new CommandColumnHeaderTemplate(ASPxGridView1);
    }
}
