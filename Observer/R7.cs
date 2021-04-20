using System;

namespace DesignPatterns
{
    public class R7 {
        public void Publicar(string graus) {
            Console.WriteLine($"R7: Campos : {graus}ºC\n");
        }
    }

    // public class R7 : IObserver {
    //     private ISubject subject;

    //     public void Update(ISubject subject) {
    //         Console.WriteLine($"R7: Campos : {(subject as Subject).Temperatura}ºC\n");
    //     }
    // } 
}

