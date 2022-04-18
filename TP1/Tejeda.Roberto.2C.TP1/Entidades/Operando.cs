using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// recarga constructor double
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// recarga constructo strin
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
        public string Numero
        {
            set
            {
                if (value is not null && value.Length > 0)
                {
                    this.numero = ValidarOperando(value);
                }
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
            if (double.TryParse(strNumero, out operando))
            {
                return operando;
            }
            return operando;
        }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            if (n1 is not null && n2 is not null)
            {
                return n1.numero + n2.numero;
            }
            return double.MinValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            if (n1 is not null && n2 is not null)
            {
                return n1.numero * n2.numero;
            }
            return double.MinValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
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
                       retorno=false;
                        break;
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// BinarioDecimal validará que se trate de un binario y luego convertirá esenúmero binario a decimal,
        /// en caso de ser posible.Caso contrario retornará "Valorinválido".
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
            double auxiliarDecimal = 0;
            string retorno = string.Empty;
            if(EsBinario(binario))
            {
                if(binario=="0")
                {
                    retorno = "0";
                }else
                {
                    char[] auxiliarArray = binario.ToCharArray();
                    Array.Reverse(auxiliarArray);
                    for (int i = 0; i < auxiliarArray.Length; i++)
                    {
                        if (auxiliarArray[i] == '1')
                        {
                            auxiliarDecimal = auxiliarDecimal + (double)Math.Pow(2, i);
                            retorno=auxiliarDecimal.ToString();
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
        /// Ambas opciones del método DecimalBinario convertirán un número decimal abinario, en caso de ser posible.
        /// Caso contrario retornará "Valor inválido". Reutilizarcódigo.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            int auxiliar;
            string binario = string.Empty;
            if ((int)numero == 0)
            {
                binario = "0";
            }else
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
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
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
