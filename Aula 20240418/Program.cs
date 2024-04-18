using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20240418
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tioPaulo = false;
            int filhos = 3, heranca = 200000;

            try
            {                
                if(tioPaulo)
                {
                    throw (new Exception());
                }
                Console.WriteLine("Herança pra cada: " + heranca / filhos);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ele ainda está vivo");                
            }
            finally
            {
                Console.WriteLine("Finalizando...");
            }
        }
    }
}
