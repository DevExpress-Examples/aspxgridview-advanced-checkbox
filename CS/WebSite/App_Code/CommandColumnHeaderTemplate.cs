using System.Web.UI;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView;

public class CommandColumnHeaderTemplate : ITemplate {
    private ASPxGridView gridView = null;
    
    public CommandColumnHeaderTemplate(ASPxGridView gridView) {
        this.gridView = gridView;
    }

    #region ITemplate Members

    public void InstantiateIn(Control container) {
        HtmlInputCheckBox checkBox = new HtmlInputCheckBox();
        container.Controls.Add(checkBox);
        checkBox.Attributes.Add("onclick", string.Format("{0}.SelectAllRowsOnPage(this.checked);", gridView.ClientInstanceName));
    }

    #endregion
}
