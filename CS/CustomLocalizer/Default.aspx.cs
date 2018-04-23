using System;
using System.Data;

namespace CustomLocalizer {

    public partial class _Default : System.Web.UI.Page {

        protected void Page_Init(object sender, EventArgs e) {
            ASPxGridView1.DataSource = GetDemoData();
        }
        protected void Page_Load(object sender, EventArgs e) {
            ASPxGridView1.DataBind();
        }

        private DataTable GetDemoData() {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Rows.Add(1);
            return table;
        }

        protected void ASPxGridView1_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e) {
            CancelEditing(e);
        }
        protected void ASPxGridView1_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e) {
            CancelEditing(e);
        }
        protected void ASPxGridView1_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e) {
            CancelEditing(e);
        }

        private void CancelEditing(System.ComponentModel.CancelEventArgs e) {
            e.Cancel = true;
            ASPxGridView1.CancelEdit();
        }

    }
}
