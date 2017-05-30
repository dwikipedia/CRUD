using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ExtentionMethod;
using ConsoleApp1.Model;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PesertaBootcamp peserta = new PesertaBootcamp();
            try
            {
                peserta.mainMenu();
            }
            catch (Exception)
            {
                Console.WriteLine("Inputan salah");
                peserta.toMainMenu();
            }
        }

    }
}
