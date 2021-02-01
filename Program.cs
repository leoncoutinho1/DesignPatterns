using System;

namespace DesignPatterns
{
    public class Program {
        
        static void Main() {
            CalculoNormal cn = new CalculoNormal();
            CalculoHappyHour chh = new CalculoHappyHour();

            Comanda comanda = new Comanda(cn);

            comanda.AdicionaBebida(5);
            comanda.AdicionaBebida(7.5);
            comanda.AdicionaBebida(7.5);

            comanda.setComandaCalculo(chh);

            comanda.AdicionaBebida(5);

            Console.WriteLine(comanda.total);


        }
    } 
}

