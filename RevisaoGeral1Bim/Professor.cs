using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoGeral1Bim
{
    internal abstract class Professor
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Titulacao { get; set; }

        public string Endereco { get; set; }

        public string Contato { get; set; }

        public virtual void DarAulas()
        {
            Console.WriteLine("Dando Aulas");
        }

        public abstract void CorrigirProvas();
    }
}
