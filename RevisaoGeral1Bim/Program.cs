using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoGeral1Bim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escrevendo no console");
            string text = Console.ReadLine();

            // String é a classe de Strings (utiliza-se as classes primitivas)
            // string é o tipo de objeto (utiliza-se os métodos da variável string)

            Console.WriteLine("Digite um numero");
            //formas de conversão:
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            /*
            if/else
            switch/case

            for/while

            */

            // Aluno a = new Aluno();
            // IAluno a = new IAluno();
            // Professor prof = new Professor();
        }
    }
}
