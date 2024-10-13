using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoG3.Entidades
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string mail;
        private string telefono;
        private bool aptoFisico;

        public Cliente(string nombre, string apellido, string dni, string mail, string telefono, bool aptoFisico)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.mail = mail;
            this.telefono = telefono;
            this.aptoFisico = aptoFisico;
        }

        public string Nombre => nombre; // Propiedad de solo lectura para Nombre
        public string Apellido => apellido; // Propiedad de solo lectura para Apellido
        public string DNI => dni; // Propiedad de solo lectura para DNI
        public string Mail => mail; // Propiedad de solo lectura para Mail
        public string Telefono => telefono; // Propiedad de solo lectura para Telefono
        public bool AptoFisico => aptoFisico; // Propiedad de solo lectura para AptoFisico

        public virtual void DarAlta()
        {
            /* Lógica para dar de alta a un cliente */
        }

        public virtual void DarBaja()
        {
            /* Lógica para dar de baja a un cliente */
        }

        public bool PresentaApto()
        {
            return aptoFisico;
        }
    }
}