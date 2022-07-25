using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        /// <summary>
        /// constructor por defecto (sin parámetros) asignará valor 0 al atributo numero.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Recarga constructor double
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero) : this(numero.ToString())
        {
        }
        /// <summary>
        /// Recarga constructo strin usando Propiedad
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero) 
        {
            this.Numero = strNumero;
        }
        /// <summary>
        /// Propiedad asigna un valor al atributo número, previa validación.
        /// En este lugar será el único en todo el código que llame al método ValidarOperando.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        /// <summary>
        /// Comprobar que el valor recibido sea numérico
        /// </summary>
        /// <param name="strNumero">valor a verificar y retotnar como double</param>
        /// <returns> Retorna operando en formato double, Caso contrario, retornará 0.</returns>
        private double ValidarOperando(string strNumero)
        {
            double operando = 0;

            for (int i = 0; i < strNumero.Length; i++)
            {
                if (strNumero[i] == '.')
                {
                    return operando;
                }
            }
            if (double.TryParse(strNumero, out operando) && Double.IsNormal(operando))
            {
                return operando;
            }

            return operando;
        }
        /// <summary>
        /// Recarga Operando -
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            if (n1 is not null && n2 is not null)
            {
                return n1.numero - n2.numero;
            }
            return double.MinValue;
        }
        /// <summary>
        /// Recarga Operando +
        /// </summary>
        /// <param name="n1">Objeto 1</param>
        /// <param name="n2">Objeto 2</param>
        /// <returns>Valor de la operacion y si no lo logra double.Min.Value</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            if (n1 is not null && n2 is not null)
            {
                return n1.numero + n2.numero;
            }
            return double.MinValue;
        }
        /// <summary>
        /// Recarga Operando *
        /// </summary>
        /// <param name="n1">Objeto 1</param>
        /// <param name="n2">Objeto 2</param>
        /// <returns>Valor de la operacion y si no lo logra double.Min.Value</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            if (n1 is not null && n2 is not null)
            {
                return n1.numero * n2.numero;
            }
            return double.MinValue;
        }
        /// <summary>
        /// Recarga Operando /
        /// </summary>
        /// <param name="n1">Objeto 1</param>
        /// <param name="n2">Objeto 2</param>
        /// <returns>Valor de la operacion y si no lo logra double.Min.Value</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n1 is not null && n2 is not null && n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            return double.MinValue;
        }
        /// <summary>
        /// Validar que la cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario">Cadena a validar</param>
        /// <returns>True si es binario</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            if (binario.Length > 0 && binario is not null)
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    if (!(binario[i] == '1' || binario[i] == '0'))
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// Valida que se trate de un binario y convierte esenúmero binario a decimal.
        /// </summary>
        /// <param name="binario">String a corroborar</param>
        /// <returns>String Binario, Caso contrario retorna "Valorinválido".</returns>
        public static string BinarioDecimal(string binario)
        {
            double auxiliarDecimal = 0;
            string retorno = string.Empty;
            if (EsBinario(binario))
            {
                if (binario == "0")
                {
                    retorno = "0";
                }
                else
                {
                    char[] auxiliarArray = binario.ToCharArray();
                    Array.Reverse(auxiliarArray);
                    for (int i = 0; i < auxiliarArray.Length; i++)
                    {
                        if (auxiliarArray[i] == '1')
                        {
                            auxiliarDecimal = auxiliarDecimal + (double)Math.Pow(2, i);
                            retorno = auxiliarDecimal.ToString();
                        }
                    }
                }
            }
            else
            {
                retorno = "Valor Inválido";
            }
            return retorno;
        }
        /// <summary>
        /// Convierte un número decimal abinario, en caso de ser posible.
        /// </summary>
        /// <param name="numero">Double a convertir</param>
        /// <returns>String Decimal</returns>
        public static string DecimalBinario(double numero)
        {
            int auxiliar;
            string binario = string.Empty;
            if ((int)numero == 0)
            {
                binario = "0";
            }
            else
            {
                while ((int)numero > 0)
                {
                    auxiliar = (int)numero % 2;
                    numero = (int)numero / 2;
                    binario = auxiliar.ToString() + binario;
                }
            }
            return binario;
        }
        /// <summary>
        ///  Convierte un número decimal abinario, en caso de ser posible.
        /// </summary>
        /// <param name="numero">String</param>
        /// <returns>String Decimal</returns>
        public static string DecimalBinario(string numero)
        {
            int auxiliar;
            string binario = string.Empty;
            if (int.TryParse(numero, out auxiliar))
            {
                binario = DecimalBinario(auxiliar);
            }
            return binario;
        }
    }
}