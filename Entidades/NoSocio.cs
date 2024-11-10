using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoG3.Entidades
{
    internal class NoSocio : Cliente
    {
        private int id;
        private decimal pagoDiario;

        public NoSocio(string nombre, string apellido, string dni, string mail, string telefono, bool aptoFisico, int id, decimal pagoDiario)
            : base(nombre, apellido, dni, mail, telefono, aptoFisico)
        {
            this.id = id;
            this.pagoDiario = pagoDiario;
        }

        public void abonarActividad()
        {
            // Lógica para abonar actividades
        }

        public void inscribirActividad()
        {
            // Lógica para inscribir a un no socio en una actividad
        }
    }
}

