using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.DTO.DTOs;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Dominio.Modelos.Abstracciones;
using NominaPISIB.Infraestructura.AccesoDatos;
using NominaPISIB.Infraestructura.AccesoDatos.Repositorio;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class NominasServicioImpl : ServicioImpl<Nominas>, INominasServicio
    {
        private INominasRepo _repo;
        private readonly NominaPISIBContext _context;

        IEmpleadosServicio empl;
        IBonificacionesServicio boni;
        IDescuentosServicio desc;
        IAsistenciasServicio asis;
        IInasistenciasServicio inas;

        public NominasServicioImpl(INominasRepo repo, 
            NominaPISIBContext context, IEmpleadosServicio empl, 
            IBonificacionesServicio boni, IDescuentosServicio desc, 
            IAsistenciasServicio asis, IInasistenciasServicio inas) : base(context)
        {
            _repo = repo;
            _context = context;
            this.empl = empl;
            this.boni = boni;
            this.desc = desc;
            this.asis = asis;
            this.inas = inas;
        }

        public async Task InsertarNominaAutomatizado(string name, string lastname, int year, int month)
        {
            //LO QUE ENVIAREMOS AL FINAL DE ESTA FUNCion
            Nominas nomina;
            //usar los servicios para llenar la nomina: empleados, bonificaciones, descuentos, asistencias, inasistencias
            var empleado = await empl.ObtenerEmpleadoPorNombre(name, lastname);
            var contrato = await empl.ObtenerContratoActivoPorEmpleado(name, lastname);
            var bonifica = await boni.ObtenerBonificacionesDeEmpleadoPorAnioYMes(name, lastname, year, month);
            var descu = await desc.ObtenerDescuentosDeEmpleadoPorAnioYMes(name, lastname, year, month);
            var asiste =  await asis.ObtenerAsistenciasEmpleadoPorAnioYMes(name, lastname, year, month);
            var inasiste = await inas.ObtenerInasistenciasEmpleadoPorAnioYMes(name, lastname, year, month);
            //ahora cálculos tanto de boni, descu, asis e inas
            decimal boniCalc = boni.CalcularBonificacionesDeEmpleadoPorAnioYMes(bonifica);
            decimal descuCalc = desc.CalcularDescuentosDeEmpleadoPorAnioYMes(descu);
            int asisteCalc = asis.ContabilizarAsistencias(asiste);
            int inasisteCalcRemu = inas.ContabilizarInasistenciasRemunerables(inasiste); // insistencias remunerables, añade 
            int inasisteCalcNoRemu = inas.ContabilizarInasistenciasNoRemunerables(inasiste); // inasistencias no remunerables
            //datos necesario para calcular Salario neto
            int diasTrabajados = asisteCalc + inasisteCalcRemu - inasisteCalcNoRemu;
            decimal salarioBruto = contrato.Salario;
            //calculo de salarioNeto
            decimal salrioNetoResult = CalcularSalarioNeto(salarioBruto, diasTrabajados);

            nomina = new Nominas
            {
                idEmpleado = empleado.idEmpleado,
                NominaAnio = year,
                NominaBonificaciones = boniCalc,
                NominaDescuentos = descuCalc,
                NominaMes = month,
                NominaSalarioBase = salarioBruto,
                NominaSalarioNeto = salrioNetoResult,
                NominaFechaEmision = DateOnly.FromDateTime(DateTime.Today),
            };

            await _repo.AddAsync(nomina);
            
        }


        public decimal CalcularSalarioNeto(decimal salaritoBruto, int diasTrabajados)
        {
            var salarioDia = salaritoBruto / 30; // el salario mensual por día siempre se divide para 30 días

            var salarioNeto = salarioDia * diasTrabajados; //ese salrio dario lo multiplicamos por días laborados

            return salarioNeto;
        }
        public Task<bool> ActualizarNominaAsync(int nominaId, DateTime nuevaFechaPago, decimal nuevoMonto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarNominaAsync(int nominaId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarNominaActualizadaAsync(int nominaId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarNominaEliminadaAsync(int nominaId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotificarNominaRegistradaAsync(int empleadoId, string mensajeNotificacion)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerDetallesNominaAsync(int nominaId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerNominasPorEmpleadoAsync(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ObtenerNominasPorFechaAsync(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarNominaAsync(int empleadoId, DateTime fechaPago, decimal monto)
        {
            throw new NotImplementedException();
        }

    }
}
