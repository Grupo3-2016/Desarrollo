using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ClasesBase;

namespace ClaseConexion
{
    public class TrabajarOrden
    {
        public static string InsertOrden(int nProv,DateTime dFecha,bool bPagada,decimal nTotal,DataTable dtLista)
        {
            Orden_Compra Obj = new Orden_Compra();
            Obj.Prov_ID = nProv;
            Obj.Oc_Fecha = dFecha;
            Obj.Pagada = bPagada;
            Obj.Total = nTotal;
            List<Item_Orden_Compra> items = new List<Item_Orden_Compra>();
            foreach (DataRow row in dtLista.Rows)
            {
                Item_Orden_Compra detalle = new Item_Orden_Compra();
                detalle.Art_ID = Convert.ToInt32(row["idarticulo"].ToString());
                detalle.ItemCantidad = Convert.ToDecimal(row["Cantidad"].ToString());
                detalle.ItemCosto = Convert.ToDecimal(row["Costo"].ToString());
                detalle.ItemImporte = Convert.ToDecimal(row["Subtotal"].ToString());
                items.Add(detalle);
            }
            return Obj.InsertOrden(Obj,items);
        }

        public static DataTable ViewOrden()
        {
            return new Orden_Compra().ListOrden();
        }
        public static DataTable ViewOrden(int nID)
        {
            Orden_Compra obj = new Orden_Compra();
            obj.Prov_ID = nID;
            return obj.ListOrden(obj);
        }
        public static DataTable ViewItem(int nID)
        {
            Item_Orden_Compra Obj = new Item_Orden_Compra();
            Obj.Art_ID = nID;
            return new Orden_Compra().ListItem(Obj);
        }
        public static DataTable GetOrden(int nID)
        {
            Orden_Compra obj = new Orden_Compra();
            obj.Oc_ID = nID;
            return obj.GetOrden(obj);
        }
    }
}
