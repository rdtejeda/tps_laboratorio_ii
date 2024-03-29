﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        /// <summary>
        /// Atributos
        /// </summary>
        List<Vehiculo> vehiculos;
        int espacioDisponible;
        /// <summary>
        /// Tipo de valor ETipo
        /// </summary>
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }
        #region "Constructores"
        /// <summary>
        /// Constructo
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Constructor con atributos
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Taller(int espacioDisponible) : this()
        {
            if(espacioDisponible >0)
            {
                this.espacioDisponible = espacioDisponible;
            }
        }
        #endregion
        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion
        #region "Métodos"
        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="t">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>Strin Builder con la información</returns>
        public static string Listar(Taller t, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();
            if (t != null && tipo >= 0)
            {                
                sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", t.vehiculos.Count, t.espacioDisponible);
                sb.AppendLine("");
                foreach (Vehiculo v in t.vehiculos)
                {
                    switch (tipo)
                    {
                        case ETipo.Ciclomotor:
                            if (v is Ciclomotor)
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            break;
                        case ETipo.Sedan:
                            if (v is Sedan)
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            break;
                        case ETipo.SUV:
                            if (v is Suv)
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            break;
                        default:
                            sb.AppendLine(v.Mostrar());
                            break;
                    }
                }
            }
            return sb.ToString();
        }
        #endregion
        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="t">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller t, Vehiculo vehiculo)
        {
            if (t!=null)
            {
                foreach (Vehiculo v in t.vehiculos)
                {
                    if (v == vehiculo)
                        return t;
                }

                if (t.vehiculos.Count < t.espacioDisponible)
                {
                    t.vehiculos.Add(vehiculo);
                }
            }
            return t;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="t">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller t, Vehiculo vehiculo)
        {
            if (t != null)
            {
                foreach (Vehiculo v in t.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        t.vehiculos.Remove(vehiculo);
                        break;
                    }
                }
            }
            return t;
        }
        #endregion
    }
}