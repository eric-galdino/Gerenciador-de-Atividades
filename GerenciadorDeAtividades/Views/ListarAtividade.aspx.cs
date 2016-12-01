using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GerenciadorDeAtividades.Views
{
    public partial class ListarAtividade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.Sort("Id", SortDirection.Descending);
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                Response.Redirect("~/Views/EditarAtividade.aspx?AtivId=" + row.Cells[0].Text);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BindGridView()
        {
            AtividadeDAO dao = new AtividadeDAO();
            DataTable dt = dao.PegarDados();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }


}