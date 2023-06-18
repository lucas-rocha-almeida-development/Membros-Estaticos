using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menbros_Estaticos {
    internal class Program {
        
        static double Pi = 3.14;//Definição do valor de PI
        static void Main(string[] args) {
            /*Fazer um programa para ler um valor numérico qualquer,
             * e daí mostrar quanto seria o valor de uma circuferência e do volume de uma esfera
             * para um raio daquele valor. Informar também o valor de PI com duas casas decimais.
             */
            Console.Write("Entre com valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circuferencia(raio);
            double volume2 = Volume (raio);
            Console.WriteLine("Circuferência: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        } 

        static double Circuferencia (double r) {
            return 2.0 * Pi * r;
        }
        
        static double Volume (double r) {
            return 4.0 /3 * Pi * Math.Pow(r,3.0);
        }

} }
