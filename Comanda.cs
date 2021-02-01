using System;

namespace DesignPatterns
{
    public class Comanda {
        
        private ICalculo comandaCalculo;
        private double total {
            get => total;
            set => total = value;
        }
        
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
            total += comandaCalculo.calcular(valor);
        }        
    } 
}

