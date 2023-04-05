using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoGeral1Bim
{
    internal class AlunoOuvinte
    {
        public string Nome { get; set; }

        public int RA { get; set; }

        public string Endereco { get; set; }

        public string Contato { get; set; }

        public void Andar()
        {
            Console.WriteLine("Andando");
        }

       public void Estudar()
        {
            Console.WriteLine("Estudando");
        }

        public void FazerProva()
        {
            Console.WriteLine("Fazendo a Prova");
        }
    }
}
