using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_de_Filmes
{
    class Filme
    {
        public string Nome;
        public DateTime Data;
        public string Local;

        public Filme(string Nome, DateTime Data, string Local)
        {
            this.Nome = Nome;
            this.Data = Data;
            this.Local = Local;
        }
    }
}
