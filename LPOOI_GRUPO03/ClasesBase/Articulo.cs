using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class Articulo
    {
        private int art_Id;
        private string art_Descrip;
        private int fam_Id;
        private int uM_Id;
        private decimal art_Costo;
        private decimal art_Margen_Beneficio;
        private decimal art_Precio;
        private decimal art_Stock_Min;
        private decimal art_Stock_Max;
        private decimal art_Stock_Reposicion;
        private decimal art_Stock_Actual;
        private bool art_Maneja_Stock;
        private string txt_Buscar;

        //Getters and Setters
        public int Art_Id
        {
            get { return art_Id; }
            set { art_Id = value; }
        }
        public string Art_Descrip
        {
            get { return art_Descrip; }
            set { art_Descrip = value; }
        }
        public int Fam_Id
        {
            get { return fam_Id; }
            set { fam_Id = value; }
        }
        public int UM_Id
        {
            get { return uM_Id; }
            set { uM_Id = value; }
        }
        public decimal Art_Costo
        {
            get { return art_Costo; }
            set { art_Costo = value; }
        }
        public decimal Art_Margen_Beneficio
        {
            get { return art_Margen_Beneficio; }
            set { art_Margen_Beneficio = value; }
        }
        public decimal Art_Precio
        {
            get { return art_Precio; }
            set { art_Precio = value; }
        }
        public decimal Art_Stock_Min
        {
            get { return art_Stock_Min; }
            set { art_Stock_Min = value; }
        }
        public decimal Art_Stock_Max
        {
            get { return art_Stock_Max; }
            set { art_Stock_Max = value; }
        }
        public decimal Art_Stock_Reposicion
        {
            get { return art_Stock_Reposicion; }
            set { art_Stock_Reposicion = value; }
        }
        public decimal Art_Stock_Actual
        {
            get { return art_Stock_Actual; }
            set { art_Stock_Actual = value; }
        }
        public bool Art_Maneja_Stock
        {
            get { return art_Maneja_Stock; }
            set { art_Maneja_Stock = value; }
        }
        public string Txt_Buscar
        {
            get { return txt_Buscar; }
            set { txt_Buscar = value; }
        }

        //Constructors
        public Articulo()
        {
        }
        public Articulo(int nArtID, string sArtDescrip, int nFamID, int nUMID, decimal nArtCosto, decimal nArtMargen,
            decimal nArtPrecio, decimal nStockMin, decimal nStockMax, decimal nStockRep, decimal nStockActual, bool bStockManeja,
            string sBuscar)
        {
            Art_Id = nArtID;
            Art_Descrip = sArtDescrip;
            Fam_Id = nFamID;
            UM_Id = nUMID;
            Art_Costo = nArtCosto;
            Art_Margen_Beneficio = nArtMargen;
            Art_Precio = nArtPrecio;
            Art_Stock_Min = nStockMin;
            Art_Stock_Max = nStockMax;
            Art_Stock_Reposicion = nStockRep;
            Art_Maneja_Stock = bStockManeja;
            Txt_Buscar = sBuscar;
        }
        public Articulo(int nArtID, string sArtDescrip, int nFamID, int nUMID, decimal nArtCosto, decimal nArtMargen,
            decimal nArtPrecio, decimal nStockMin, decimal nStockMax, decimal nStockRep, decimal nStockActual, bool bStockManeja)
        {
            Art_Id = nArtID;
            Art_Descrip = sArtDescrip;
            Fam_Id = nFamID;
            UM_Id = nUMID;
            Art_Costo = nArtCosto;
            Art_Margen_Beneficio = nArtMargen;
            Art_Precio = nArtPrecio;
            Art_Stock_Min = nStockMin;
            Art_Stock_Max = nStockMax;
            Art_Stock_Reposicion = nStockRep;
            Art_Maneja_Stock = bStockManeja;
        }
        //Listas
        public DataTable ListUM()
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "ListUM";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();

            oDA.Fill(oDT);
            return oDT;
        }
        public DataTable ListFamilia()
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "ListFamilia";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();

            oDA.Fill(oDT);
            return oDT;
        }
        public DataTable ListArticulos()
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "ListArticulos";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();

            oDA.Fill(oDT);
            return oDT;
        }

        //CRUD
        //Insert
        public string InsertArticle(Articulo oArt)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "InsertArticle";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@descrip", oArt.Art_Descrip);
            oCmd.Parameters.AddWithValue("@fam", oArt.Fam_Id);
            oCmd.Parameters.AddWithValue("@um", oArt.UM_Id);
            oCmd.Parameters.AddWithValue("@costo", oArt.Art_Costo);
            oCmd.Parameters.AddWithValue("@margen", oArt.Art_Margen_Beneficio);
            oCmd.Parameters.AddWithValue("@precio", oArt.Art_Precio);
            oCmd.Parameters.AddWithValue("@smin", oArt.Art_Stock_Min);
            oCmd.Parameters.AddWithValue("@smax", oArt.Art_Stock_Max);
            oCmd.Parameters.AddWithValue("@srepo", oArt.Art_Stock_Reposicion);
            oCmd.Parameters.AddWithValue("@sactual", oArt.Art_Stock_Actual);
            oCmd.Parameters.AddWithValue("@maneja", oArt.Art_Maneja_Stock);

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
        public string UpdateArticle(Articulo oArt)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "UpdateArticle";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", oArt.Art_Id);
            oCmd.Parameters.AddWithValue("@descrip", oArt.Art_Descrip);
            oCmd.Parameters.AddWithValue("@fam", oArt.Fam_Id);
            oCmd.Parameters.AddWithValue("@um", oArt.UM_Id);
            oCmd.Parameters.AddWithValue("@costo", oArt.Art_Costo);
            oCmd.Parameters.AddWithValue("@margen", oArt.Art_Margen_Beneficio);
            oCmd.Parameters.AddWithValue("@precio", oArt.Art_Precio);
            oCmd.Parameters.AddWithValue("@smin", oArt.Art_Stock_Min);
            oCmd.Parameters.AddWithValue("@smax", oArt.Art_Stock_Max);
            oCmd.Parameters.AddWithValue("@srepo", oArt.Art_Stock_Reposicion);
            oCmd.Parameters.AddWithValue("@sactual", oArt.Art_Stock_Actual);
            oCmd.Parameters.AddWithValue("@maneja", oArt.Art_Maneja_Stock);

            try
            {
                oCnn.Open();
                sRpta = oCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro de Articulo";
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
        public string DeleteArticle(Articulo oArt)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "DeleteArticle";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", oArt.Art_Id);
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
        public DataTable SearchArticles(Articulo oArt)
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SearchArticles";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@pattern", "%" + oArt.Txt_Buscar + "%");

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

        public DataTable OrderArticlesCod()
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "OrderArticlesByCod";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);

            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        public DataTable OrderArticlesDescrip()
        {
            SqlConnection oCnn = new SqlConnection(Conexion.sConexion);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "OrderArticlesByDescrip";
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);

            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
    }
}
