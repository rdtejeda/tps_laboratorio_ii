using System;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Validar y realizar la operación pedida entre ambos números
        /// </summary>
        /// <param name="num1">Primer numero ingresado</param>
        /// <param name="num2">Segundo numero ingresado</param>
        /// <param name="operador">Opaerando</param>
        /// <returns>Resultado </returns>
        ///
        
        static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            if (ValidarOperador(operador) == '+')
            {
                resultado = num1 + num2;
            }
            return resultado;
        }
        
        /// <summary>
        /// validar que el operadorrecibido sea +, -, / o *. Caso contrario
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Si se trata de un Operador valido lo retorna y de no ser asi retornará +</returns>
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';
            if (Equals(operador, '+'))
            {
                retorno = operador;
            }
            if (Equals(operador, '-'))
            {
                retorno = operador;
            }
            if (Equals(operador, '*'))
            {
                retorno = operador;
            }
            if (Equals(operador, '/'))
            {
                retorno = operador;
            }
            return retorno;
        }
    }
}
