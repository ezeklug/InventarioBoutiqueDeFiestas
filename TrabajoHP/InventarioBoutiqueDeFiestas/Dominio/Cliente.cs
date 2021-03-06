﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{

    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Boolean Activo { get; set; }

        public Cliente(string pNombre, string pApellido, string pDireccion, string pTelefono, string pEmail)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Direccion = pDireccion;
            Telefono = pTelefono;
            Email = pEmail;
            Activo = true;
        }

        public override string ToString()
        {
            return Nombre+ " " + Apellido;
        }

        public Cliente() { }
    }
}
