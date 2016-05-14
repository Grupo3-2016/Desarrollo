using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;
using System.Data;
using System.Data.SqlClient;

namespace ClaseConexion
{
    public class TrabajarArticulo
    {
        public static string InsertArt(string sArtDescrip, int nFamID, int nUMID, decimal nArtCosto, decimal nArtMargen,
            decimal nArtPrecio, decimal nStockMin, decimal nStockMax, decimal nStockRep, decimal nStockActual, bool bStockManeja)
        {
            Articulo Obj = new Articulo();
            Obj.Art_Descrip = sArtDescrip;
            Obj.Fam_Id = nFamID;
            Obj.UM_Id = nUMID;
            Obj.Art_Costo = nArtCosto;
            Obj.Art_Margen_Beneficio = nArtMargen;
            Obj.Art_Precio = nArtPrecio;
            Obj.Art_Stock_Min = nStockMin;
            Obj.Art_Stock_Max = nStockMax;
            Obj.Art_Stock_Reposicion = nStockRep;
            Obj.Art_Stock_Actual = nStockActual;
            Obj.Art_Maneja_Stock = bStockManeja;

            return Obj.InsertArticle(Obj);
        }
        public static string EditArt(int nArtID, string sArtDescrip, int nFamID, int nUMID, decimal nArtCosto, decimal nArtMargen,
            decimal nArtPrecio, decimal nStockMin, decimal nStockMax, decimal nStockRep, decimal nStockActual, bool bStockManeja)
        {
            Articulo Obj = new Articulo();
            Obj.Art_Id = nArtID;
            Obj.Art_Descrip = sArtDescrip;
            Obj.Fam_Id = nFamID;
            Obj.UM_Id = nUMID;
            Obj.Art_Costo = nArtCosto;
            Obj.Art_Margen_Beneficio = nArtMargen;
            Obj.Art_Precio = nArtPrecio;
            Obj.Art_Stock_Min = nStockMin;
            Obj.Art_Stock_Max = nStockMax;
            Obj.Art_Stock_Reposicion = nStockRep;
            Obj.Art_Stock_Actual = nStockActual;
            Obj.Art_Maneja_Stock = bStockManeja;

            return Obj.UpdateArticle(Obj);
        }
        public static string DeleteArt(int nID)
        {
            Articulo Obj = new Articulo();
            Obj.Art_Id = nID;
            return Obj.DeleteArticle(Obj);
        }
        public static DataTable SearchArt(string sPattern)
        {
            Articulo Obj = new Articulo();
            Obj.Txt_Buscar = sPattern;
            return Obj.SearchArticles(Obj);
        }
        public static DataTable ViewUM()
        {
            return new Articulo().ListUM();
        }
        public static DataTable ViewFamilia()
        {
            return new Articulo().ListFamilia();
        }
        public static DataTable ViewArticles()
        {
            return new Articulo().ListArticulos();
        }

        public static DataTable OrderArticles()
        {
            return new Articulo().OrderArticlesDescrip();
        }
    }
}
