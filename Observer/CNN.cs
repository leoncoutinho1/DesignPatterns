using System;

namespace DesignPatterns
{
    public class CNN {
        public void Publicar(string graus) {
            Console.WriteLine($"CNN: Campos dos Goytacazes: {graus}ºC\n");
        }
    }

    // public class CNN : IObserver {
    //     private ISubject subject;

    //     public void Update(ISubject subject) {
    //         Console.WriteLine($"CNN: Campos dos Goytacazes: {(subject as Subject).Temperatura}ºC\n");
    //     }
    // } 
}

