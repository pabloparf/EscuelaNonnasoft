using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Qrys
    {
       //Query para verificar si el usuario puede entrar al sistema y con que rol
       public const string QryLogin = "SELECT P.ID_PERSONA, P.NOMBRE, P.APELLIDO_PATERNO, P.APELLIDO_MATERNO, P.LOG_NAME, P.PASSWORD, P.ID_ROL, P.status, M.URL, P.EMAIL, P.SEXO, P.NACIONALIDAD, P.FECHA_INGRESO, R.ID_ROL FROM PERSONA P, " +
		                                      "MODULO M, rol R, rol_modulo R_M WHERE P.LOG_NAME=@logname AND P.ID_ROL=R.ID_ROL AND R_M.ID_ROL=P.ID_ROL AND P.STATUS = 'A' AND R_M.ID_MODULO = M.ID_MODULO";
    }
}
