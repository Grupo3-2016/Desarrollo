using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class Proveedor
    {
        private int prov_Id;
        private string prov_Nombre;
        private string prov_Domicilio;
        private string prov_Departamento;
        private string prov_Codigo_Postal;
        private string prov_Telefono;
        private string prov_Email;
        private string txt_Buscar;

        //Getters and Setters
        public int Prov_Id
        {
            get { return prov_Id; }
            set { prov_Id = value; }
        }
        public string Prov_Nombre
        {
            get { return prov_Nombre; }
            set { prov_Nombre = value; }
        }
        public string Prov_Domicilio
        {
            get { return prov_Domicilio; }
            set { prov_Domicilio = value; }
        }
        public string Prov_Departamento
        {
            get { return prov_Departamento; }
            set { prov_Departamento = value; }
        }
        public string Prov_Codigo_Postal
        {
            get { return prov_Codigo_Postal; }
            set { prov_Codigo_Postal = value; }
        }
        public string Prov_Telefono
        {
            get { return prov_Telefono; }
            set { prov_Telefono = value; }
        }
        public string Prov_Email
        {
            get { return prov_Email; }
            set { prov_Email = value; }
        }
        public string Txt_Buscar
        {
            get { return txt_Buscar; }
            set { txt_Buscar = value; }
        }
        
        //Constructors
        public Proveedor()
        {
        }
        public Proveedor(int nID,string sNombre,string sDomicilio,string sDepartamento,string sCP,string sTel, string sMail,string sBuscar)
        {
            Prov_Id = nID;
            Prov_Nombre = sNombre;
            Prov_Domicilio = sDomicilio;
            Prov_Departamento = sDepartamento;
            Prov_Codigo_Postal = sCP;
            Prov_Telefono = sTel;
            Prov_Email = sMail;
            Txt_Buscar = sBuscar;
        }

        //CRUD
        //Insert
        public string InsertProvider(Proveedor oProv)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "InsertProvider";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@nombre", oProv.Prov_Nombre);
            oCmd.Parameters.AddWithValue("@domi", oProv.Prov_Domicilio);
            oCmd.Parameters.AddWithValue("@depto", oProv.Prov_Departamento);
            oCmd.Parameters.AddWithValue("@codpos", oProv.Prov_Codigo_Postal);
            oCmd.Parameters.AddWithValue("@tel", oProv.Prov_Telefono);
            oCmd.Parameters.AddWithValue("@email", oProv.Prov_Email);
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
        //Update
        public string UpdateProvider(Proveedor oProv)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "UpdateProvider";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", oProv.Prov_Id);
            oCmd.Parameters.AddWithValue("@nombre", oProv.Prov_Nombre);
            oCmd.Parameters.AddWithValue("@domi", oProv.Prov_Domicilio);
            oCmd.Parameters.AddWithValue("@depto", oProv.Prov_Departamento);
            oCmd.Parameters.AddWithValue("@codpos", oProv.Prov_Codigo_Postal);
            oCmd.Parameters.AddWithValue("@tel", oProv.Prov_Telefono);
            oCmd.Parameters.AddWithValue("@email", oProv.Prov_Email);
            try
            {
                oCnn.Open();
                sRpta = oCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";
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
        //Delete
        public string DeleteProvider(Proveedor oProv)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "DeleteProvider";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", oProv.Prov_Id);
            try
            {
                oCnn.Open();
                sRpta = oCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";
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
        //Search
        public DataTable SearchProviders(Proveedor oProv)
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SearchProviders";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@pattern", "%" + oProv.Txt_Buscar + "%");

            DataTable oDT = new DataTable();
            try
            {
                SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
                oDA.Fill(oDT);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                oDT = null;
            }
            return oDT;
        }

        //Lista
        public DataTable ListProviders()
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "ListProviders";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);

            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        public DataTable OrderProviders()
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "OrderProviders";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);

            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        
    }
}
