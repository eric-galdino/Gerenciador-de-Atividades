using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gerenciador_De_Atividades.Code.Model
{
    public class Atividade
    {

        private int id;
        private string titulo;
        private string descricao;
        private string data;
        private string hora;
        private string periodicidade;
        private int status;

        public Atividade(string titulo, string descricao, string data, string hora,
            string periodicidade, int status)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.data = data;
            this.hora = hora;
            this.periodicidade = periodicidade;
            this.status = status;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public string Periodicidade
        {
            get { return periodicidade; }
            set { periodicidade = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}