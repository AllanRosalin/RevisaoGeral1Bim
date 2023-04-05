using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoGeral1Bim
{
    internal class AlunoEspecial : Aluno
    {
        public override void FazerProva()
        {
            // Funcionalidade sobrescrita
            Console.WriteLine("Não fazendo prova - só estudando");
        }
    }
}
