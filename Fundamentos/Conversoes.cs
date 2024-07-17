using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CursoCSharp.Fundamentos {
    class Conversoes {

        public static void Executar() {

            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado 1: {0}", idadeInteiro);

            Console.Write("Digite o primeiro numero:");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);

            Console.Write("Digite o segundo numero:");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultdao 2: {0}", numero2);
        }
    }
}
