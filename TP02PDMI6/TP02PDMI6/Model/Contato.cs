using System;
using System.Collections.Generic;
using System.Text;

namespace TP02PDMI6.Model
{
    class Contato
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }
        public string Pais { get; set; }
        public override string ToString()
        {
            return Nome;
        }

    }
}
