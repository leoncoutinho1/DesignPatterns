using System;

namespace DesignPatterns
{
    public class BBC {
        public void Publicar(string graus) {
            Console.WriteLine($"BBC: A temperatura em Campos é de : {graus}ºC\n");
        }
    }

    // public class BBC : IObserver {
    //     private ISubject subject;
    //     public void Update(ISubject subject) {
    //         Console.WriteLine($"BBC: A temperatura em Campos é de : {(subject as Subject).Temperatura}ºC\n");
    //     }
    // } 
}

