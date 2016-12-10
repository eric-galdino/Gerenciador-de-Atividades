using Gerenciador_De_Atividades.Code.Model;
using Gerenciador_De_Atividades.Code.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace Gerenciador_De_Atividades.Code.DAO
{
    public class AtividadeDAO
    {

        public bool InserirAtividade(Atividade atividade)
        {
            SqlConnection con = new SqlConnection(Connection.Connection.ConString());
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("titulo", atividade.Titulo);
            cmd.Parameters.AddWithValue("descricao", atividade.Descricao);
            cmd.Parameters.AddWithValue("data", atividade.Data);
            cmd.Parameters.AddWithValue("hora", atividade.Hora);
            cmd.Parameters.AddWithValue("periodicidade", atividade.Periodicidade);
            cmd.Parameters.AddWithValue("status", atividade.Status);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoverAtividade(int id)
        {
            SqlConnection con = new SqlConnection(Connection.Connection.ConString());
            SqlCommand cmd = new SqlCommand("sp_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AtualizarAtividade(Atividade atividade)
        {
            SqlConnection con = new SqlConnection(Connection.Connection.ConString());
            SqlCommand cmd = new SqlCommand("sp_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", atividade.Id);
            cmd.Parameters.AddWithValue("titulo", atividade.Titulo);
            cmd.Parameters.AddWithValue("descricao", atividade.Descricao);
            cmd.Parameters.AddWithValue("data", atividade.Data);
            cmd.Parameters.AddWithValue("hora", atividade.Hora);
            cmd.Parameters.AddWithValue("periodicidade", atividade.Periodicidade);
            cmd.Parameters.AddWithValue("status", atividade.Status);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable PegarDados()
        {
            SqlConnection con = new SqlConnection(Connection.Connection.ConString());
            SqlCommand cmd = new SqlCommand("sp_getdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

    }
}