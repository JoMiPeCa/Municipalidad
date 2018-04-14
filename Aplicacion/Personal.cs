using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class Personal
    {
        private string rut { get; set; }
        private string nombre { get; set; }
        private string apellidoPaterno { get; set; }
        private string apellidoMaterno { get; set; }
        private DateTime contratoFecha { get; set; }
        private string mail { get; set; }
        private char sexo { get; set; }
        private string usuario { get; set; }
        private string password { get; set; }
        private int tipoUserCodUser { get; set; }
        private int cargoCodUser { get; set; }
        private int departamentoCodDepto { get; set; }


        public Personal()
    {
            rut = string.Empty;
            nombre = string.Empty;
            apellidoMaterno = string.Empty;
            apellidoPaterno = string.Empty;
            contratoFecha = DateTime.Today;
            mail = string.Empty;
            sexo = ' ';
            usuario = string.Empty;
            password = string.Empty;
            tipoUserCodUser = 0;
            cargoCodUser = 0;
            departamentoCodDepto = 0;
    }

    }
}
