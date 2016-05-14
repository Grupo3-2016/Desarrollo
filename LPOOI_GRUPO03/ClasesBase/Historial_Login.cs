using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class Historial_Login
    {
        private int hLog_Id;
        private int usr_Id;
        private DateTime hLog_Fecha_Hora;
        
        // Getters and Setters
        public int HLog_Id
        {
            get { return hLog_Id; }
            set { hLog_Id = value; }
        }
        public int Usr_Id
        {
            get { return usr_Id; }
            set { usr_Id = value; }
        }
        public DateTime HLog_Fecha_Hora
        {
            get { return hLog_Fecha_Hora; }
            set { hLog_Fecha_Hora = value; }
        }
        
        //Constructors
        public Historial_Login()
        {
        }
        public Historial_Login(int nLog_ID,int nUser_ID,DateTime dtLog_Hora)
        {
            hLog_Id = nLog_ID;
            usr_Id = nUser_ID;
            hLog_Fecha_Hora = dtLog_Hora;
        }
        
        //Insert
        public string InsertHLog(Historial_Login oHLog)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "InsertHLog";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@usrID", oHLog.Usr_Id);
            oCmd.Parameters.AddWithValue("@logHF", oHLog.HLog_Fecha_Hora);
            try
            {
                oCnn.Open();
                sRpta = oCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex)
            {
                sRpta = ex.Message;
            }
            finally
            {
                if (oCnn.State == ConnectionState.Open) oCnn.Close();
            }
            return sRpta;
        }
    }
}
