using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ClassFolder.Lenght
{
    public class ClassLength
    {
        public double Calcular(double num1, string text1, string text2)
        {
            double resultadoFinal = 0;

            if (num1 != 0 && text1 == "Nanómetros")
            {
                resultadoFinal = CalcularNanometros(num1, text2);
            }
            else if (num1 != 0 && text1 == "Micrones")
            {
                resultadoFinal = CalcularMicrones(num1, text2);
            }
            else if (num1 != 0 && text1 == "Milímetros")
            {
                resultadoFinal = CalcularMilimetros(num1, text2);
            }
            else if (num1 != 0 && text1 == "Centímetros")
            {
                resultadoFinal = CalcularCentimetros(num1, text2);
            }
            else if (num1 != 0 && text1 == "Metros")
            {
                resultadoFinal = CalcularMetros(num1, text2);
            }
            else if (num1 != 0 && text1 == "Kilómetros")
            {
                resultadoFinal = CalcularKilimetros(num1, text2);
            }
            else if (num1 != 0 && text1 == "Pulgadas")
            {
                resultadoFinal = CalcularPulgadas(num1, text2);
            }
            else if (num1 != 0 && text1 == "Pies")
            {
                resultadoFinal = CalcularPies(num1, text2);
            }
            else if (num1 != 0 && text1 == "Yardas")
            {
                resultadoFinal = CalcularYardas(num1, text2);
            }
            else if (num1 != 0 && text1 == "Millas")
            {
                resultadoFinal = CalcularMillas(num1, text2);
            }
            else if (num1 != 0 && text1 == "Millas náuticas")
            {
                resultadoFinal = CalcularMillasNauticas(num1, text2);
            }
             
            return resultadoFinal;
        }

        private double CalcularNanometros(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Nanómetros")
            {
                resultado = num1;
            }
            else if (text2 == "Micrones")
            {
                resultado = num1 * 1000;
            }
            else if (text2 == "Milímetros")
            {
                resultado = num1 / 1000000;
            }
            else if (text2 == "Centímetros")
            {
                resultado = num1 / 10000000;
            }
            else if (text2 == "Metros")
            {
                resultado = num1 / 1000000000;
            }
            else if (text2 == "Kilómetros")
            {
                resultado = num1 / 1000000000000;
            }
            else if (text2 == "Pulgadas")
            {
                resultado = num1 / 25400000;
            }
            else if (text2 == "Pies")
            {
                resultado = num1 / 304800000;
            }
            else if (text2 == "Yardas")
            {
                resultado = num1 / 914400000;
            }
            else if (text2 == "Millas")
            {
                resultado = num1 / 1609000000000;
            }
            else if (text2 == "Millas náuticas")
            {
                resultado = num1 / 1852000000000;
            }

            return resultado;
        }

        private double CalcularMicrones(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Nanómetros")
            {
                resultado = num1 * 1000;
            }
            else if (text2 == "Micrones")
            {
                resultado = num1;
            }
            else if (text2 == "Milímetros")
            {
                resultado = num1 / 1000;
            }
            else if (text2 == "Centímetros")
            {
                resultado = num1 / 10000;
            }
            else if (text2 == "Metros")
            {
                resultado = num1 / 1000000;
            }
            else if (text2 == "Kilómetros")
            {
                resultado = num1 / 1000000000;
            }
            else if (text2 == "Pulgadas")
            {
                resultado = num1 / 25400;
            }
            else if (text2 == "Pies")
            {
                resultado = num1 / 304800;
            }
            else if (text2 == "Yardas")
            {
                resultado = num1 / 914400;
            }
            else if (text2 == "Millas")
            {
                resultado = num1 / 1609000000;
            }
            else if (text2 == "Millas náuticas")
            {
                resultado = num1 / 1852000000;
            }

            return resultado;
        }

        private double CalcularMilimetros(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Nanómetros")
            {
                resultado = num1 * 1000000;
            }
            else if (text2 == "Micrones")
            {
                resultado = num1 * 1000;
            }
            else if (text2 == "Milímetros")
            {
                resultado = num1;
            }
            else if (text2 == "Centímetros")
            {
                resultado = num1 / 10;
            }
            else if (text2 == "Metros")
            {
                resultado = num1 / 1000;
            }
            else if (text2 == "Kilómetros")
            {
                resultado = num1 / 1000000;
            }
            else if (text2 == "Pulgadas")
            {
                resultado = num1 / 25.4;
            }
            else if (text2 == "Pies")
            {
                resultado = num1 / 305;
            }
            else if (text2 == "Yardas")
            {
                resultado = num1 / 914;
            }
            else if (text2 == "Millas")
            {
                resultado = num1 / 1609000;
            }
            else if (text2 == "Millas náuticas")
            {
                resultado = num1 / 1852000;
            }

            return resultado;
        }

        private double CalcularCentimetros(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Nanómetros")
            {
                resultado = num1 * 10000000;
            }
            else if (text2 == "Micrones")
            {
                resultado = num1 * 10000;
            }
            else if (text2 == "Milímetros")
            {
                resultado = num1 * 10;
            }
            else if (text2 == "Centímetros")
            {
                resultado = num1;
            }
            else if (text2 == "Metros")
            {
                resultado = num1 / 100;
            }
            else if (text2 == "Kilómetros")
            {
                resultado = num1 / 100000;
            }
            else if (text2 == "Pulgadas")
            {
                resultado = num1 / 2.54;
            }
            else if (text2 == "Pies")
            {
                resultado = num1 / 30.48;
            }
            else if (text2 == "Yardas")
            {
                resultado = num1 / 91.44;
            }
            else if (text2 == "Millas")
            {
                resultado = num1 / 160934;
            }
            else if (text2 == "Millas náuticas")
            {
                resultado = num1 / 185200;
            }

            return resultado;
        }

        private double CalcularMetros(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Nanómetros")
            {
                resultado = num1 * 1000000000;
            }
            else if (text2 == "Micrones")
            {
                resultado = num1 * 1000000;
            }
            else if (text2 == "Milímetros")
            {
                resultado = num1 * 1000;
            }
            else if (text2 == "Centímetros")
            {
                resultado = num1 * 100;
            }
            else if (text2 == "Metros")
            {
                resultado = num1;
            }
            else if (text2 == "Kilómetros")
            {
                resultado = num1 / 1000;
            }
            else if (text2 == "Pulgadas")
            {
                resultado = num1 * 39.37;
            }
            else if (text2 == "Pies")
            {
                resultado = num1 * 3.281;
            }
            else if (text2 == "Yardas")
            {
                resultado = num1 * 1.094;
            }
            else if (text2 == "Millas")
            {
                resultado = num1 / 1609;
            }
            else if (text2 == "Millas náuticas")
            {
                resultado = num1 / 1852;
            }

            return resultado;
        }

        private double CalcularKilimetros(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Nanómetros")
            {
                resultado = num1 * 1000000000000;
            }
            else if (text2 == "Micrones")
            {
                resultado = num1 * 1000000000;
            }
            else if (text2 == "Milímetros")
            {
                resultado = num1 * 1000000;
            }
            else if (text2 == "Centímetros")
            {
                resultado = num1 * 100000;
            }
            else if (text2 == "Metros")
            {
                resultado = num1 * 1000;
            }
            else if (text2 == "Kilómetros")
            {
                resultado = num1;
            }
            else if (text2 == "Pulgadas")
            {
                resultado = num1 * 39370;
            }
            else if (text2 == "Pies")
            {
                resultado = num1 * 3281;
            }
            else if (text2 == "Yardas")
            {
                resultado = num1 * 1094;
            }
            else if (text2 == "Millas")
            {
                resultado = num1 / 1.609;
            }
            else if (text2 == "Millas náuticas")
            {
                resultado = num1 / 1.852;
            }

            return resultado;
        }

        private double CalcularPulgadas(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Nanómetros")
            {
                resultado = num1 * 25400000;
            }
            else if (text2 == "Micrones")
            {
                resultado = num1 * 25400;
            }
            else if (text2 == "Milímetros")
            {
                resultado = num1 * 25.4;
            }
            else if (text2 == "Centímetros")
            {
                resultado = num1 * 2.54;
            }
            else if (text2 == "Metros")
            {
                resultado = num1 / 39.37;
            }
            else if (text2 == "Kilómetros")
            {
                resultado = num1 / 39370;
            }
            else if (text2 == "Pulgadas")
            {
                resultado = num1;
            }
            else if (text2 == "Pies")
            {
                resultado = num1 / 12;
            }
            else if (text2 == "Yardas")
            {
                resultado = num1 / 36;
            }
            else if (text2 == "Millas")
            {
                resultado = num1/ 63360;
            }
            else if (text2 == "Millas náuticas")
            {
                resultado = num1 / 72913;
            }

            return resultado;
        }

        private double CalcularPies(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Nanómetros")
            {
                resultado = num1 * 304800000;
            }
            else if (text2 == "Micrones")
            {
                resultado = num1 * 304800;
            }
            else if (text2 == "Milímetros")
            {
                resultado = num1 * 305;
            }
            else if (text2 == "Centímetros")
            {
                resultado = num1 * 30.48;
            }
            else if (text2 == "Metros")
            {
                resultado = num1 / 3.281;
            }
            else if (text2 == "Kilómetros")
            {
                resultado = num1 / 3281;
            }
            else if (text2 == "Pulgadas")
            {
                resultado = num1 * 12;
            }
            else if (text2 == "Pies")
            {
                resultado = num1;
            }
            else if (text2 == "Yardas")
            {
                resultado = num1 / 3;
            }
            else if (text2 == "Millas")
            {
                resultado = num1 / 5280;
            }
            else if (text2 == "Millas náuticas")
            {
                resultado = num1 / 6076;
            }

            return resultado;
        }

        private double CalcularYardas(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Nanómetros")
            {
                resultado = num1 * 914400000;
            }
            else if (text2 == "Micrones")
            {
                resultado = num1 * 914400;
            }
            else if (text2 == "Milímetros")
            {
                resultado = num1 * 914;
            }
            else if (text2 == "Centímetros")
            {
                resultado = num1 * 91.44;
            }
            else if (text2 == "Metros")
            {
                resultado = num1 / 1.094;
            }
            else if (text2 == "Kilómetros")
            {
                resultado = num1 / 1094;
            }
            else if (text2 == "Pulgadas")
            {
                resultado = num1 * 36;
            }
            else if (text2 == "Pies")
            {
                resultado = num1 * 3;
            }
            else if (text2 == "Yardas")
            {
                resultado = num1;
            }
            else if (text2 == "Millas")
            {
                resultado = num1 / 1760;
            }
            else if (text2 == "Millas náuticas")
            {
                resultado = num1 / 2025;
            }

            return resultado;
        }

        private double CalcularMillas(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Nanómetros")
            {
                resultado = num1 * 1609000000000;
            }
            else if (text2 == "Micrones")
            {
                resultado = num1 * 1609000000;
            }
            else if (text2 == "Milímetros")
            {
                resultado = num1 * 1609000;
            }           
            else if (text2 == "Centímetros")
            {
                resultado = num1 * 160934;
            }
            else if (text2 == "Metros")
            {
                resultado = num1 * 1609;
            }
            else if (text2 == "Kilómetros")
            {
                resultado = num1 * 1.609;
            }
            else if (text2 == "Pulgadas")
            {
                resultado = num1 * 63360;
            }
            else if (text2 == "Pies")
            {
                resultado = num1 * 5280;
            }
            else if (text2 == "Yardas")
            {
                resultado = num1 * 1760;
            }
            else if (text2 == "Millas")
            {
                resultado = num1;
            }
            else if (text2 == "Millas náuticas")
            {
                resultado = num1 / 1.151;
            }

            return resultado;
        }

        private double CalcularMillasNauticas(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Nanómetros")
            {
                resultado = num1 * 1852000000000;
            }
            else if (text2 == "Micrones")
            {
                resultado = num1 * 1852000000;
            }
            else if (text2 == "Milímetros")
            {
                resultado = num1 * 1852000;
            }
            else if (text2 == "Centímetros")
            {
                resultado = num1 * 185200;
            }
            else if (text2 == "Metros")
            {
                resultado = num1 * 1852;
            }
            else if (text2 == "Kilómetros")
            {
                resultado = num1 * 1.852;
            }
            else if (text2 == "Pulgadas")
            {
                resultado = num1 * 72913;
            }
            else if (text2 == "Pies")
            {
                resultado = num1 * 6076;
            }
            else if (text2 == "Yardas")
            {
                resultado = num1 * 2025;
            }
            else if (text2 == "Millas")
            {
                resultado = num1 * 1.151;
            }
            else if (text2 == "Millas náuticas")
            {
                resultado = num1;
            }

            return resultado;
        }
    }
}