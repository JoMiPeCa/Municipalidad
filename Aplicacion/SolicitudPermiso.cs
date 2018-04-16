using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    class SolicitudPermiso
    {
        private int codigoPermiso { get; set; }
        private int diasSolicitados { get; set; }
        private DateTime fechaInicio { get; set; }
        private DateTime fechaTermino { get; set; }
        private string motivoSolicitud { get; set; }

        public SolicitudPermiso()
        {
            codigoPermiso = 0;
            diasSolicitados = 0;
            fechaInicio = DateTime.Today;
            fechaTermino = DateTime.Today;
            motivoSolicitud = string.Empty;
        }

        public SolicitudPermiso()
        {

        }
    }
}
