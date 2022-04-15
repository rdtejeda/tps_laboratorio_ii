using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCalculadora
{
    static class Calculadora
    {
        /// <summary>
        /// Validar y realizar la operación pedida entre ambos números
        /// </summary>
        /// <param name="num1">Primer numero ingresado</param>
        /// <param name="num2">Segundo numero ingresado</param>
        /// <param name="operador">Opaerando</param>
        /// <returns>Resultado </returns>
        public static double Operar(Operando num1,Operando num2, char operador)
        {
            double resultado=0;
           
            return resultado;
        }
        /// <summary>
        /// validar que el operadorrecibido sea +, -, / o *. Caso contrario 
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Si se trata de un Operador valido lo retorna y de no ser asi retornará +</returns>
        private static char ValidarOperador(char operador)
        {
            return operador;
        }
    }
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
            this.numero=numero;
        }
        /// <summary>
        /// recarga constructo strin
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {    
            double numero;
            double.TryParse(strNumero, out numero);
            this.numero = numero;
        }
        /// <summary>
        /// Propiedad Numero asigna un valor al atributo número, previa validación.
        /// En este lugar será el único en todo el código que llame al método ValidarOperando.
        /// </summary>
        public string Numero
        {            
            set 
            {
                if(value is not null && value.Length>0)
                {
                    double aux;
                    double.TryParse(value, out aux);
                    this.numero = aux; 
                }
            }
        }
        /// <summary>
        /// Comprobar que el valor recibido sea numérico y lo retorna en formato double.
        /// Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero">valor a verificar y retotnar como double</param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double operando=0;

            if (strNumero is not null && strNumero.Length>0 && double.TryParse(strNumero, out operando))
            {
                return operando;
            }
            return operando;
        }
        /// <summary>
        /// Validar que la cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario">Cadena a validar</param>
        /// <returns>True si es binario</returns>
        private bool EsBinario(string binario)
        {
            bool retorno=false;
            if(binario.Length>0&& binario is not null)
            {
                for (int i = 0; i <binario.Length; i++)
                {
                    if(binario[i] != '1'|| binario[i] != '0')
                    {
                       return  retorno;
                    }
                }
                retorno=true;
            }
            return retorno;
        }
        /*
         * Los métodos BinarioDecimal y DecimalBinario convertirán el resultado,
         * trabajarán con enteros positivos, quedándose para esto con el valor absoluto y entero del double recibido:
         */
        /// <summary>
        /// BinarioDecimal validará que se trate de un binario y luego convertirá esenúmero binario a decimal,
        /// en caso de ser posible.Caso contrario retornará "Valorinválido".
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string retorno= "Valorinválido";

            return retorno;
        }
        /// <summary>
        /// Ambas opciones del método DecimalBinario convertirán un número decimal abinario, en caso de ser posible.
        /// Caso contrario retornará "Valor inválido". Reutilizarcódigo.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string retorno = "Valor invalido";
            
            return retorno;
        }
        public string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";

            return retorno;
        }

        public static double operator -(Operando n1,Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            return n1.numero / n2.numero;
        }
    }
}
