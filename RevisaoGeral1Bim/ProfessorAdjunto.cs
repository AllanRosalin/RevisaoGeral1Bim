using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoGeral1Bim
{
    internal class ProfessorAdjunto : Professor
    {
        public override void DarAulas()
        {
            Console.WriteLine("Dando outras aulas em conjunto");
        }

        public override void CorrigirProvas()
        {
            Console.WriteLine("Corrigindo várias provas");
        }
    }
}
