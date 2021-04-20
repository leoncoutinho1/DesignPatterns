using System;

namespace DesignPatterns
{
    public class PatternStrategy {
        static void Main1() {
            CalculoNormal cn = new CalculoNormal();
            CalculoHappyHour chh = new CalculoHappyHour();

            Comanda comanda = new Comanda(cn);

            comanda.AdicionaBebida(5);
            comanda.AdicionaBebida(7.5);
            comanda.AdicionaBebida(7.5);
            if (DateTime.Now.TimeOfDay > TimeSpan.FromHours(23)) {
                comanda.setComandaCalculo(chh);
            }
            

            comanda.AdicionaBebida(5);

            Console.WriteLine(comanda.total);


        }
    } 
}

