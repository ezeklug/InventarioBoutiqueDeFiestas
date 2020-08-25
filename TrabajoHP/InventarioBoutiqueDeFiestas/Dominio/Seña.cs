﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{
    public class Seña
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }

        /// <summary>
        /// constructor de seña.
        /// </summary>
        /// <param name="pMonto"></param>
        public Seña(double pMonto)
        {
            Fecha = DateTime.Now;
            Monto = pMonto;
        }
    }
}
