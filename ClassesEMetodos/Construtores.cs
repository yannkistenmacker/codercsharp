using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() {

        }
    }
    
    
    
    class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Modelo = "325i";
            carro1.Fabricante = "BMW";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

            var carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };

            var carro4 = new Carro("Yuan", "byd", 2024);
            Console.WriteLine($"O modelo é {carro4.Modelo}, o fabricante é {carro4.Fabricante.ToUpper()} e o ano é {carro4.Ano}");
        }
    }
}
