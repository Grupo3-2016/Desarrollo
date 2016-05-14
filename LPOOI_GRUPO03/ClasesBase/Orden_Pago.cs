using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class Orden_Pago
    {
        private int op_ID;
        private int oc_ID;
        private int prov_ID;
        private DateTime op_Fecha;
        private DateTime desde;
        private DateTime hasta;
        private decimal op_Importe;

        public int Op_ID
        {
            get { return op_ID; }
            set { op_ID = value; }
        }
        public int Oc_ID
        {
            get { return oc_ID; }
            set { oc_ID = value; }
        }
        public int Prov_ID
        {
            get { return prov_ID; }
            set { prov_ID = value; }
        }
        public DateTime Op_Fecha
        {
            get { return op_Fecha; }
            set { op_Fecha = value; }
        }
        public DateTime Desde
        {
            get { return desde; }
            set { desde = value; }
        }
        public DateTime Hasta
        {
            get { return hasta; }
            set { hasta = value; }
        }
        public decimal Op_Importe
        {
            get { return op_Importe; }
            set { op_Importe = value; }
        }

        //Constructors
        public Orden_Pago()
        {
        }
        public Orden_Pago(int nOP,int nOC,int nProv, DateTime dFecha,decimal nImporte)
        {
            Op_ID = nOP;
            Oc_ID = nOC;
            prov_ID = nProv;
            Op_Fecha = dFecha;
            Op_Importe = nImporte;
        }

        //Insert
        public string InsertPago(Orden_Pago oPago)
        {
            string sRpta = "";
            SqlConnection cnn = new SqlConnection(Conexion.sConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "InsertPago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@compra", oPago.Oc_ID);
            cmd.Parameters.AddWithValue("@prov", oPago.Prov_ID);
            cmd.Parameters.AddWithValue("@fecha", oPago.Op_Fecha);
            cmd.Parameters.AddWithValue("@importe", oPago.Op_Importe);

            try
            {
                cnn.Open();
                sRpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (sRpta == "OK")
                {
                    sRpta = UpdateCompra(oPago.Oc_ID, true);
                }
            }
            catch (Exception ex)
            {
                sRpta = ex.Message;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }
            return sRpta;
        }
        public string UpdateCompra(int nOC,bool bPago)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();

            oCmd.CommandText = "UpdateCompra";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", nOC);
            oCmd.Parameters.AddWithValue("@pagada", bPago);
            try
            {
                oCnn.Open();
                sRpta = oCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";
            }
            catch (Exception ex)
            {
                sRpta = ex.Message + "";
            }
            finally
            {
                if (oCnn.State == ConnectionState.Open) oCnn.Close();
            }
            return sRpta;
        }
        public DataTable ListOrden()
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "ListPagadas";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        public DataTable ListPagos()
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "ListPagos";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        public DataTable ListPagos(Orden_Pago oOrden)
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "ListPagosByCod";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", oOrden.Prov_ID);

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        public DataTable ListPagosFecha(Orden_Pago oOrden)
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "ListPagosByFecha";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@desde", oOrden.Desde);
            oCmd.Parameters.AddWithValue("@hasta", oOrden.Hasta);

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
    }
}
