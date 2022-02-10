using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ClassFolder.Temperature
{
    class ClassTemperature
    {
        public double Calcular(double num1, string text1, string text2)
        {
            double resultadoFinal = 0;
            
            if (text1 == "Celsius")
            {
                resultadoFinal = this.CalcularCelsius(num1, text2);
            }
            else if (text1 == "Fahrenheit")
            {
                resultadoFinal = this.CalcularFahrenheit(num1, text2);
            }
            else if (text1 == "Kelvin")
            {
                resultadoFinal = this.CalcularKelvin(num1, text2);
            }
            return resultadoFinal;
        }

        private double CalcularCelsius(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Celsius")
            {
                resultado = num1;
            }
            else if (text2 == "Fahrenheit")
            {
                resultado = (num1 * 9 / 5) + 32;
            }
            else if (text2 == "Kelvin")
            {
                resultado = num1 + 273.15;
            }
            return resultado;
        }

        private double CalcularFahrenheit(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Celsius")
            {
                resultado = (num1 - 32) * 5 / 9;
            }
            else if (text2 == "Fahrenheit")
            {
                resultado = num1;
            }
            else if (text2 == "Kelvin")
            {
                resultado = (num1 - 32) * 5 / 9 + 273.15;
            }
            return resultado;
        }

        private double CalcularKelvin(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Celsius")
            {
                resultado = num1 - 273.15;
            }
            else if (text2 == "Fahrenheit")
            {
                resultado = (num1 - 273.15) * 9 / 5 + 32;
            }
            else if (text2 == "Kelvin")
            {
                resultado = num1;
            }
            return resultado;
        }
    }
}
