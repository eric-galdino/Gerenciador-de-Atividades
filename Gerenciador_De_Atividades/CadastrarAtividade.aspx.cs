using Gerenciador_De_Atividades.Code.DAO;
using Gerenciador_De_Atividades.Code.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gerenciador_De_Atividades
{
    public partial class CadastrarAtividade : System.Web.UI.Page
    {
        AtividadeDAO dao = new AtividadeDAO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateAtividade_Click(object sender, EventArgs e)
        {
            Atividade atividade = new Atividade(Titulo.Text, Descricao.Text, DataSelecionada(),
                Hora.Text, Periodicidade.SelectedValue, Convert.ToInt16(Status.Checked));
            dao.InserirAtividade(atividade);
            limparCampos();
            Mensagem.Visible = true;
        }

        private void limparCampos()
        {
            Titulo.Text = "";
            Descricao.Text = "";
            Calendar.SelectedDates.Clear();
            Hora.Text = "";
            Periodicidade.SelectedIndex = 0;
            Status.Checked = false;
        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            string data_selecionada = DataSelecionada();
            String[] cadeia = data_selecionada.Split('\\');
            if (cadeia.Length == 3)
            {
                Calendar.SelectedDate = new DateTime(Convert.ToInt16(cadeia[2]),
                    Convert.ToInt16(cadeia[1]), Convert.ToInt16(cadeia[0]));
            }
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