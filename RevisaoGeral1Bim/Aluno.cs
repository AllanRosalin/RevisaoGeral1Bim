using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoGeral1Bim
{
    internal class Aluno
    {
        // public string RA { get; set; }
        private int RA { get; set; }

        public int getRA()
        {
            return RA;
        }

        public void getRA(int value)
        {
            RA = value;
        }

        public string Nome { get; set;}

        public string Endereco { get; set; }

        public void Andar()
        {
            // Funcionalidade de andar
        }

        public void Estudar()
        {
            // Funcionalidade de estudar
        }

        public void Estudar(int value)
        {
            // Estudar - Sobrecarga
        }

        public virtual void FazerProva()
        {
            Console.WriteLine("Fazendo prova");
        }

        public Aluno()
        {
            // Definição de inicialização de objeto
        }
    }
}
