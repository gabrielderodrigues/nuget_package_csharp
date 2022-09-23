using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2022, 09, 23);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diff = dataFimPagamento - dataCorrente;

            string message = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diff);

            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente);
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
