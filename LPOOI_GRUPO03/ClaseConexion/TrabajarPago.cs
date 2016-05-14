using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ClasesBase;


namespace ClaseConexion
{
    public class TrabajarPago
    {
        public static string InsertOrden(int nOC,int nProv, DateTime dFecha,decimal nTotal)
        {
            Orden_Pago Obj = new Orden_Pago();
            Obj.Oc_ID = nOC;
            Obj.Prov_ID = nProv;
            Obj.Op_Fecha = dFecha;
            Obj.Op_Importe = nTotal;
            return Obj.InsertPago(Obj);
        }
        public static DataTable ViewPagos()
        {
            return new Orden_Pago().ListPagos();
        }
        public static DataTable ViewPagos(int nID)
        {
            Orden_Pago obj = new Orden_Pago();
            obj.Prov_ID = nID;
            return obj.ListPagos(obj);
        }
        public static DataTable ViewPagos(DateTime dDesde,DateTime dHasta)
        {
            Orden_Pago obj = new Orden_Pago();
            obj.Desde = dDesde;
            obj.Hasta = dHasta;
            return obj.ListPagosFecha(obj);
        }
        public static DataTable ViewOrden()
        {
            return new Orden_Pago().ListOrden();
        }
    }
}
