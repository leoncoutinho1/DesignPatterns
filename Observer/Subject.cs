using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Subject {
        private string _temperatura{ get; set; } = "0";
        public string MedeTemperatura() {
            this._temperatura = new Random().Next(0, 40).ToString();
            return this._temperatura;
        }
    } 
    // public class Subject : ISubject {
    //     public string Temperatura{ get; set; } = "0";
    //     private List<IObserver> _observers = new List<IObserver>();
        
    //     public void Attach(IObserver observer)
    //     {
    //          Console.WriteLine("Adicionando um observer\n");
    //         this._observers.Add(observer);
    //     }

    //     public void Dettach(IObserver observer)
    //     {
    //         Console.WriteLine("Removendo um observer\n");
    //         this._observers.Remove(observer);
    //     }

    //     public void Notify()
    //     {
    //         foreach(IObserver observer in _observers) {
    //             observer.Update(this);
    //         }
    //     }

    //     public void MedeTemperatura() {
    //         this.Temperatura = new Random().Next(0, 40).ToString();
    //         this.Notify();
    //     }
    // } 
}

