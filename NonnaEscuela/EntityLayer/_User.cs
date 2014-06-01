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

    public class _Profesor:_User
    {
        public int IDProfesor { get; set; }
        public List<int> HorasDisponible;       
    }

    public class _Domicilio:_User
    {
        public string TipoDomicilio { get; set; }
        public string Calle { get; set; }
        public string NumeroExt { get; set; }
        public string NumeroInt { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string CP { get; set; }
    }

    public class _Telefono : _User
    {
        public string TipoTelefono { get; set; }
        public string CodigoPais { get; set; }
        public string CodigoCiudad { get; set; }
        public string Numero { get; set; }
    }
}
