using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoG3.Entidades
{
    internal class Socio : Cliente
    {
        private int id;
        private bool carnetEntrega;
        private decimal cuotaMensual;
        private bool estadoPago;

        public Socio(string nombre, string apellido, string dni, string mail, string telefono, bool aptoFisico, int id, bool carnetEntrega, decimal cuotaMensual, bool estadoPago)
            : base(nombre, apellido, dni, mail, telefono, aptoFisico)
        {
            this.id = id;
            this.carnetEntrega = carnetEntrega;
            this.cuotaMensual = cuotaMensual;
            this.estadoPago = estadoPago;
        }

        public int Id => id; // Propiedad de solo lectura para Id
        public bool CarnetEntrega => carnetEntrega; // Propiedad de solo lectura para carnetEntrega
        public decimal CuotaMensual => cuotaMensual; // Propiedad de solo lectura para cuotaMensual
        public bool EstadoPago => estadoPago; // Propiedad de solo lectura para estadoPago

        public void AbonarCuota()
        {
            estadoPago = true;
            // Lógica para registrar el pago de la cuota
        }

        public void EntregarCarnet()
        {
            carnetEntrega = true;
            // Lógica para registrar que el carnet fue entregado
        }

        public void ListarSocios()
        {
            // Lógica para listar los socios desde la base de datos
        }
    }
}