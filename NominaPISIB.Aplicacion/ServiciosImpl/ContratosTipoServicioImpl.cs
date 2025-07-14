using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaPISIB.Aplicacion.Servicios;
using NominaPISIB.Infraestructura.AccesoDatos;

namespace NominaPISIB.Aplicacion.ServiciosImpl
{
    public class ContratosTipoServicioImpl : ServicioImpl<ContratosTipo>, IContratosTipoServicio
    {
        public ContratosTipoServicioImpl(NominaPISIBContext context) : base(context)
        {
        }
    }
}
