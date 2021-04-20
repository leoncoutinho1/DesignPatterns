using System;

namespace DesignPatterns
{
    public class G1 {
        public void Publicar(string graus) {
            Console.WriteLine($"G1: A temperatura em Campos neste momento é de : {graus}ºC\n");
        }
    }

    // public class G1 : IObserver {
    //     private ISubject subject;
    //     public void Update(ISubject subject) {
    //         Console.WriteLine($"G1: A temperatura em Campos neste momento é de : {(subject as Subject).Temperatura}ºC\n");
    //     }
    // } 
}

