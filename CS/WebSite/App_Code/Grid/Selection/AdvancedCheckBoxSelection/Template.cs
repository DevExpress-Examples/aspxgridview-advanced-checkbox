using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Web.ASPxGridView;

public class CommandColumnHeaderTemplate : ITemplate {
    ASPxGridView gridView = null;
    public CommandColumnHeaderTemplate(ASPxGridView gridView) {
        this.gridView = gridView;
    }

    #region ITemplate Members

    public void InstantiateIn(Control container) {
        HtmlInputCheckBox checkBox = new HtmlInputCheckBox();
        container.Controls.Add(checkBox);
        checkBox.Attributes.Add("onclick", string.Format("{0}.SelectAllRowsOnPage(this.checked);", gridView.ClientID));
    }

    #endregion
}
