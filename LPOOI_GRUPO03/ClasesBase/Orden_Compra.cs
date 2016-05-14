using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace ClasesBase
{
    public class Orden_Compra
    {
        private int oc_ID;
        private int prov_ID;
        private DateTime oc_Fecha;
        private bool pagada;
        private decimal total;
        private string txt_Buscar;

        //Getters and Setters
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
        public DateTime Oc_Fecha
        {
            get { return oc_Fecha; }
            set { oc_Fecha = value; }
        }
        public bool Pagada
        {
            get { return pagada; }
            set { pagada = value; }
        }
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        public string Txt_Buscar
        {
            get { return txt_Buscar; }
            set { txt_Buscar = value; }
        }

        //Constructors
        public Orden_Compra()
        {
        }
        public Orden_Compra(int nID,int nProv,DateTime dtFecha,bool bPago,decimal nTotal,string sBuscar)
        {
            Oc_ID = nID;
            Prov_ID = nProv;
            Oc_Fecha = dtFecha;
            Pagada = bPago;
            Total = nTotal;
            Txt_Buscar = sBuscar;
        }

        //Insert
        public string InsertOrden(Orden_Compra orden,List<Item_Orden_Compra> Detalle)
        {
            string sRpta = "";
            SqlConnection cnn = new SqlConnection(Conexion.sConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "InsertOrden";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.Add("@idorden",SqlDbType.Int).Direction=ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@prov_id", orden.Prov_ID);
            cmd.Parameters.AddWithValue("@oc_fecha", orden.Oc_Fecha);
            cmd.Parameters.AddWithValue("@pagada", orden.Pagada);
            cmd.Parameters.AddWithValue("@total", orden.Total);

            try
            {
                cnn.Open();
                SqlTransaction tran = cnn.BeginTransaction();
                cmd.Transaction = tran;
                sRpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso la Orden";
                if (sRpta.Equals("OK"))
                {
                    //Obtener el código del ingreso generado
                    this.Oc_ID = Convert.ToInt32(cmd.Parameters["@idorden"].Value);
                    foreach (Item_Orden_Compra det in Detalle)
                    {
                        det.Oc_ID = this.Oc_ID;
                        //Llamar al método insertar de la clase DDetalle_Ingreso
                        sRpta = det.InsertItem(det, ref cnn, ref tran);
                        if (!sRpta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            sRpta = UpdateArt(det.Art_ID, det.ItemCantidad, det.ItemCosto);
                            if (!sRpta.Equals("OK"))
                            {
                                break;
                            }
                            if (orden.Pagada)
                            {
                                sRpta = InsertPago(det.Oc_ID, orden.Prov_ID, orden.Oc_Fecha, orden.Total);
                            }
                        }
                    }

                }
                if (sRpta.Equals("OK"))
                {
                    tran.Commit();
                }
                else
                {
                    tran.Rollback();
                }
            }
            catch (Exception ex)
            {
                sRpta = ex.Message + " OC";
            }
            finally
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }
            return sRpta;
        }
        public string InsertPago(int nOC, int nProv, DateTime dFecha, decimal nTotal)
        {
            string sRpta = "";
            SqlConnection cnn = new SqlConnection(Conexion.sConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "InsertPago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@compra",nOC);
            cmd.Parameters.AddWithValue("@prov",nProv);
            cmd.Parameters.AddWithValue("@fecha",dFecha);
            cmd.Parameters.AddWithValue("@importe",nTotal);

            try
            {
                cnn.Open();
                sRpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
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
        public string UpdateArt(int nArt, decimal dCantidad, decimal dCosto)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();

            oCmd.CommandText = "UpdateArt";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", nArt);
            oCmd.Parameters.AddWithValue("@actual", dCantidad);
            oCmd.Parameters.AddWithValue("@costo", dCosto);
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
        //Search
        public DataTable SearchOrdenes(Orden_Compra oOrden)
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT ";
            oCmd.CommandText += "oc_id as 'Número OC', ";
            oCmd.CommandText += "prov_nombre as 'Proveedor', oc_fecha as 'Fecha', ";
            oCmd.CommandText += "pagada as 'Estado'";
            oCmd.CommandText += "FROM Orden_Compra as O";
            oCmd.CommandText += " INNER JOIN Proveedor as P ON (P.prov_id=O.prov_id)";

            oCmd.CommandText += "WHERE ";
            oCmd.CommandText += "oc_fecha LIKE @pattern OR pagada LIKE @pattern";

            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@pattern", "%" + oOrden.Txt_Buscar + "%");

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
        //Obtener Listas
        public DataTable GetOrden(Orden_Compra oOrden)
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "ObtenerOrden";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", oOrden.Oc_ID);

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);

            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        public DataTable ListOrden()
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "ListOrden";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        public DataTable ListOrden(Orden_Compra oOrden)
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "ListOrdenByCod";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", oOrden.Prov_ID);

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        public DataTable ListItem(Item_Orden_Compra oItem)
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT ";
            oCmd.CommandText += "art_id,cantidad as 'Cantidad' ,art_descrip as 'Artículo', ";
            oCmd.CommandText += "prov_nombre as 'Proveedor', ";
            oCmd.CommandText += "costo as 'Costo', importe as 'Importe'";
            oCmd.CommandText += "FROM Item_Orden_Compra as I";
            oCmd.CommandText += " INNER JOIN Articulo as A ON (A.art_id=I.art_id)";
            oCmd.CommandText += " WHERE oc_id=@id";

            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;
            oCmd.Parameters.AddWithValue("@id", oItem.Art_ID);

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        } 
    }
}
