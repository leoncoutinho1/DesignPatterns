using System;

namespace DesignPatterns
{
    class CalculoHappyHour : ICalculo {
        public double calcular(double valor) {
            return valor * 0.5;
        }
    } 
}

