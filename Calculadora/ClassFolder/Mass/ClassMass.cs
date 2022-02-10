using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ClassFolder.Mass
{
    class ClassMass
    {
        public double Calcular(double num1, string text1, string text2)
        {
            double resultadoFinal = 0;

            if (num1 != 0 && text1 == "Toneladas")
            {
              resultadoFinal = CalcularToneladas(num1, text2);
            }
            else if (num1 != 0 && text1 == "Toneladas largas (Reino Unido)")
            {
                resultadoFinal = CalcularToneladasLg(num1, text2);
            }
            else if (num1 != 0 && text1 == "Toneladas cortas (EE.UU.)")
            {
                resultadoFinal = CalcularToneladasCor(num1, text2);
            }
            else if (num1 != 0 && text1 == "Libras")
            {
                resultadoFinal = CalcularLibras(num1, text2);
            }
            else if (num1 != 0 && text1 == "Onzas")
            {
                resultadoFinal = CalcularOnzas(num1, text2);
            }
            else if (num1 != 0 && text1 == "Kilogramos")
            {
                resultadoFinal = CalcularKilog(num1, text2);
            }
            else if (num1 != 0 && text1 == "Gramos")
            {
                resultadoFinal = CalcularGramos(num1, text2);
            }

            return resultadoFinal;
        }
        private double CalcularToneladas(double num1, string text2)
        {
            double resultado = 0;
          
            if (text2 == "Toneladas")
            {
                resultado = num1;
            }
            else if (text2 == "Toneladas largas (Reino Unido)")
            {
                resultado = num1 / 1.016;
            }
            else if (text2 == "Toneladas cortas (EE.UU.)")
            {
                resultado = num1 * 1.102;
            }
            else if (text2 == "Libras")
            {
                resultado = num1 * 2205;
            }
            else if (text2 == "Onzas")
            {
                resultado = num1 * 35274;
            }
            else if (text2 == "Kilogramos")
            {
                resultado = num1 * 1000;
            }
            else if (text2 == "Gramos")
            {
                resultado = num1 * 1000000;
            }

            return resultado;
        }

        private static double CalcularToneladasLg(double num1, string text2)
        {
            double resultado = 0;         
          
            if (text2 == "Toneladas")
            {
                resultado = num1 * 1.016;
            }
            else if (text2 == "Toneladas largas (Reino Unido)")
            {
                resultado = num1;
            }
            else if (text2 == "Toneladas cortas (EE.UU.)")
            {
                resultado = num1 * 1.12;
            }
            else if (text2 == "Libras")
            {
                resultado = num1 * 2240;
            }
            else if (text2 == "Onzas")
            {
                resultado = num1 * 35840;
            }
            else if (text2 == "Kilogramos")
            {
                resultado = num1 * 1016;
            }
            else if (text2 == "Gramos")
            {
                resultado = num1 * 1016000;
            }

            return resultado;
        }

        private static double CalcularToneladasCor(double num1, string text2)
        {
            double resultado = 0;
         
            if (text2 == "Toneladas")
            {
                resultado = num1 / 1.102;
            }
            else if (text2 == "Toneladas largas (Reino Unido)")
            {
                resultado = num1 / 1.12;
            }
            else if (text2 == "Toneladas cortas (EE.UU.)")
            {
                resultado = num1;
            }
            else if (text2 == "Libras")
            {
                resultado = num1 * 2000;
            }
            else if (text2 == "Onzas")
            {
                resultado = num1 * 32000;
            }
            else if (text2 == "Kilogramos")
            {
                resultado = num1 * 907;
            }
            else if (text2 == "Gramos")
            {
                resultado = num1 * 907185;
            }

            return resultado;
        }

        private static double CalcularLibras(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Toneladas")
            {
                resultado = num1 / 2205;
            }
            else if (text2 == "Toneladas largas (Reino Unido)")
            {
                resultado = num1 / 2240;
            }
            else if (text2 == "Toneladas cortas (EE.UU.)")
            {
                resultado = num1 / 2000;
            }
            else if (text2 == "Libras")
            {
                resultado = num1;
            }
            else if (text2 == "Onzas")
            {
                resultado = num1 * 16;
            }
            else if (text2 == "Kilogramos")
            {
                resultado = num1 / 2.205;
            }
            else if (text2 == "Gramos")
            {
                resultado = num1 * 454;
            }

            return resultado;
        }

        private static double CalcularOnzas(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Toneladas")
            {
                resultado = num1 / 35274;
            }
            else if (text2 == "Toneladas largas (Reino Unido)")
            {
                resultado = num1 / 35840;
            }
            else if (text2 == "Toneladas cortas (EE.UU.)")
            {
                resultado = num1 / 32000;
            }
            else if (text2 == "Libras")
            {
                resultado = num1 / 16;
            }
            else if (text2 == "Onzas")
            {
                resultado = num1;
            }
            else if (text2 == "Kilogramos")
            {
                resultado = num1 / 35.274;
            }
            else if (text2 == "Gramos")
            {
                resultado = num1 * 28.35;
            }

            return resultado;
        }

        private static double CalcularKilog(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Toneladas")
            {
                resultado = num1 / 1000;
            }
            else if (text2 == "Toneladas largas (Reino Unido)")
            {
                resultado = num1 / 1016;
            }
            else if (text2 == "Toneladas cortas (EE.UU.)")
            {
                resultado = num1 / 907;
            }
            else if (text2 == "Libras")
            {
                resultado = num1 * 2.205;
            }
            else if (text2 == "Onzas")
            {
                resultado = num1 * 35.274;
            }
            else if (text2 == "Kilogramos")
            {
                resultado = num1;
            }
            else if (text2 == "Gramos")
            {
                resultado = num1 * 1000;
            }

            return resultado;
        }
       
        private static double CalcularGramos(double num1, string text2)
        {
            double resultado = 0;

            if (text2 == "Toneladas")
            {
                resultado = num1 / 1000000;
            }
            else if (text2 == "Toneladas largas (Reino Unido)")
            {
                resultado = num1 / 1016000;
            }
            else if (text2 == "Toneladas cortas (EE.UU.)")
            {
                resultado = num1 / 907185;
            }
            else if (text2 == "Libras")
            {
                resultado = num1 / 454;
            }
            else if (text2 == "Onzas")
            {
                resultado = num1 / 28.35;
            }
            else if (text2 == "Kilogramos")
            {
                resultado = num1 / 1000;
            }
            else if (text2 == "Gramos")
            {
                resultado = num1;
            }

            return resultado;
        }
    }
}