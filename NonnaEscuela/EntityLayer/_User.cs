using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class _User
    {
        public int ID { get; set; }
        public string Nombre {get;set;}
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Email { get; set; }      
        public string Sexo {get;set;}
        public string Nacionalidad { get; set; }
        public string LogName { get; set; }
        public string Password { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Estatus { get; set; }
        public string IDRol { get; set; }
        public bool Ingresa = false;
  
    }

    public class _Profesor
    {
        public List<int> HorasDisponible;
    }
}
