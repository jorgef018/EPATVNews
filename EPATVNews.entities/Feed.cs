using System;
using System.Collections.Generic;
using System.Text;

namespace EPATVNews.entities
{
    public class Feed
    {
        private int id;
        private int idUtilizador;
        private string titulo;
        private string descricao;
        private string imagem;
        private DateTime datainicio;
        private DateTime datafim;

        public Feed()
        {


        }

        public Feed(int id)
        {
            this.id = id;
        }

        public int IDUTILIZADOR
        {
            get { return idUtilizador; }
            set { idUtilizador = value; }
        }



        public string TITULO
        {
            get { return titulo; }
            set { titulo = value; }
        }


        public string DESCRICAO
        {
            get { return descricao; }
            set { descricao = value; }
        }


        public string IMAGEM
        {
            get { return imagem; }
            set { imagem = value; }
        }


        public DateTime DATAINICIO

        {
            get { return datainicio; }
            set { datainicio = value; }
        }


        public DateTime DATAFIM
        {
            get { return datafim; }
            set { datafim = value; }
        }

        }
}
