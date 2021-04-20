using System;

namespace DesignPatterns
{
    public class Comanda {
        private double _total;
        public double total {
            get => _total;
        }
        private ICalculo comandaCalculo;
        
        
        // public double getTotal() {
        //     return total;
        // }
        public void setComandaCalculo(ICalculo calculo) {
            comandaCalculo = calculo;
        }

        public Comanda(ICalculo calculo){
            comandaCalculo = calculo;     
        }

        public void AdicionaBebida(double valor){
            _total += comandaCalculo.calcular(valor);
        }        
    } 
}

