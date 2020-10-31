using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POCVariavelAmbiente
{
    class Program
    {
        static void Main(string[] args)
        {           
            string variavel = null;
            string valorvariavelAmbiente = null;

            variavel = Console.ReadLine();
            valorvariavelAmbiente = WindowsEnvarioment.getVariable(variavel);
            Console.WriteLine("Valor da variavel:   " + valorvariavelAmbiente);
            Console.ReadKey();
        }
    }
}