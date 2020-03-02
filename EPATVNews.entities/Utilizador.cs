using System;
using System.Collections.Generic;
using System.Text;

namespace EPATVNews.entities
{
    public class Utilizador
    {
        private int Id;
        private string username;
        private string password;

        public Utilizador()
        {


        }

        public Utilizador(int Id)
        {
            this.Id = Id;
        }

        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }



        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }

    }
}
