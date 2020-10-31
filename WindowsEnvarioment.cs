using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCVariavelAmbiente
{
    public class WindowsEnvarioment
    {
        static string valorvariavelAmbiente = null;        

        public static string getVariable(string nomeVariavel)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            { 
                valorvariavelAmbiente = Environment.GetEnvironmentVariable(nomeVariavel);               
            }
            else
            {
                //Console.WriteLine("Ops... deu ruim =(");
            }

            return valorvariavelAmbiente;
        }
    }
}