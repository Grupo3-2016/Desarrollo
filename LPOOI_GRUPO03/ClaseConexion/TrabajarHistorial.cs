using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;
using System.Data;
using System.Data.SqlClient;

namespace ClaseConexion
{
    public class TrabajarHistorial
    {
        public static string InsertHLog(int nUsr_ID, DateTime dtLog_FH)
        {
            Historial_Login Obj = new Historial_Login();
            Obj.Usr_Id = nUsr_ID;
            Obj.HLog_Fecha_Hora = dtLog_FH;
            
            return Obj.InsertHLog(Obj);
        }
    }
}
