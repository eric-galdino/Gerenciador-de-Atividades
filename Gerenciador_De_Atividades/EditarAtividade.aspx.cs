using Gerenciador_De_Atividades.Code.Connection;
using Gerenciador_De_Atividades.Code.DAO;
using Gerenciador_De_Atividades.Code.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gerenciador_De_Atividades
{
    public partial class EditarAtividade : System.Web.UI.Page
    {
            int ativId = 0;

            protected void Page_Load(object sender, EventArgs e)
            {
                ativId = Convert.ToInt32(Request.QueryString["AtivId"].ToString());
                if (!IsPostBack)
                {
                    BindTextBoxValues();
                }
            }

            private void BindTextBoxValues()
            {
                string constr = Connection.ConString();
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("select * from tbl_atividades where id=" + ativId, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                Id.Text = dt.Rows[0][0].ToString();
                Titulo.Text = dt.Rows[0][1].ToString();
                Descricao.Text = dt.Rows[0][2].ToString();
                SetData(dt.Rows[0][3].ToString());
                Hora.Text = dt.Rows[0][4].ToString();
                SetPeriodicidade(dt.Rows[0][5].ToString());
                SetCheked(dt.Rows[0][6].ToString());
            }

            private void SetPeriodicidade(string perio)
            {
                if (perio.Equals("Diário"))
                {
                    Periodicidade.SelectedIndex = 1;
                }
                else if (perio.Equals("Semanal"))
                {
                    Periodicidade.SelectedIndex = 2;
                }
                else if (perio.Equals("Mensal"))
                {
                    Periodicidade.SelectedIndex = 3;
                }
                else if (perio.Equals("Anual"))
                {
                    Periodicidade.SelectedIndex = 4;
                }
                else
                {
                    Periodicidade.SelectedIndex = 0;
                }
            }

            private void SetData(string data)
            {
                String[] cadeia = data.Split('/');
                if (cadeia.Length == 3)
                {
                    Calendar.SelectedDate = new DateTime(Convert.ToInt16(cadeia[2]),
                        Convert.ToInt16(cadeia[1]), Convert.ToInt16(cadeia[0]));
                }
            }

            private void SetCheked(string cheked)
            {
                if (cheked.Equals("True"))
                {
                    Status.Checked = true;
                }
                else
                {
                    Status.Checked = false;
                }
            }

            protected void Calendar_SelectionChanged(object sender, EventArgs e)
            {

            }

            protected void btnUpdate_Click(object sender, EventArgs e)
            {
                AtividadeDAO dao = new AtividadeDAO();
                Atividade atividade = new Atividade(Titulo.Text, Descricao.Text, DataSelecionada(),
                Hora.Text, Periodicidade.SelectedValue, Convert.ToInt16(Status.Checked));
                atividade.Id = ativId;
                dao.AtualizarAtividade(atividade);
                Mensagem1.Visible = true;
            }

            protected void btnCancel_Click(object sender, EventArgs e)
            {
                Response.Redirect("~/ListarAtividade");
            }

            protected void btnDelete_Click(object sender, EventArgs e)
            {
                AtividadeDAO dao = new AtividadeDAO();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Atividade removida com sucesso" + "');", true);
                dao.RemoverAtividade(ativId);

                Response.Redirect("~/ListarAtividade");
            }

            private string DataSelecionada()
            {
                string data_selecionada = "";
                foreach (DateTime day in Calendar.SelectedDates)
                {
                    data_selecionada += day.Date.ToShortDateString() + " ";
                }
                return data_selecionada;
            }
        }
 }