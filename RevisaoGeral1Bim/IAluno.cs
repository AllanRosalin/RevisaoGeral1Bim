using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoGeral1Bim
{
    internal interface IAluno
    {
        string Name { get; set; }

        int RA { get; set; }

        string Endereco { get; set; }

        string Contato { get; set; }

        void Andar();

        void Estudar();

        void FazerProva();
    }
}
