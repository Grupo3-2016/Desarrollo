using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class Item_Orden_Compra
    {
        private int itemID;
        private int oc_ID;
        private int art_ID;
        private decimal itemCosto;
        private decimal itemCantidad;
        private decimal itemImporte;

        //Getters and Setters
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        public int Oc_ID
        {
            get { return oc_ID; }
            set { oc_ID = value; }
        }
        public int Art_ID
        {
            get { return art_ID; }
            set { art_ID = value; }
        }
        public decimal ItemCosto
        {
            get { return itemCosto; }
            set { itemCosto = value; }
        }
        public decimal ItemCantidad
        {
            get { return itemCantidad; }
            set { itemCantidad = value; }
        }
        public decimal ItemImporte
        {
            get { return itemImporte; }
            set { itemImporte = value; }
        }

        //Constructors
        public Item_Orden_Compra()
        {
        }
        public Item_Orden_Compra(int nID,int nOC,int nArt,decimal dCosto,decimal dCantidad,decimal dImporte)
        {
            ItemID = nID;
            Oc_ID = nOC;
            Art_ID = nArt;
            ItemCosto = dCosto;
            ItemCantidad = dCantidad;
            ItemImporte = dImporte;
        }
        public Item_Orden_Compra( int nOC, int nArt, decimal dCosto, decimal dCantidad, decimal dImporte)
        {
            
            Oc_ID = nOC;
            Art_ID = nArt;
            ItemCosto = dCosto;
            ItemCantidad = dCantidad;
            ItemImporte = dImporte;
        }

        //Insert
        public string InsertItem(Item_Orden_Compra item,ref SqlConnection SqlCon,ref SqlTransaction SqlTran)
        {
            string sRpta;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "InsertItem";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = SqlCon;
            cmd.Transaction = SqlTran;

            cmd.Parameters.AddWithValue("@oc_id", item.Oc_ID);
            cmd.Parameters.AddWithValue("@art_id", item.Art_ID);
            cmd.Parameters.AddWithValue("@costo", item.itemCosto);
            cmd.Parameters.AddWithValue("@cantidad", item.ItemCantidad);
            cmd.Parameters.AddWithValue("@importe", item.ItemImporte);
            
            sRpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Item";
        
            return sRpta;
        }
    }
}
