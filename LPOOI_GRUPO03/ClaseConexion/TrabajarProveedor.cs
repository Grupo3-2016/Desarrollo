using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;
using System.Data;
using System.Data.SqlClient;

namespace ClaseConexion
{
    public class TrabajarProveedor
    {
        public static string InsertProvider(string sNombre, string sDomicilio, string sDepartamento, string sCP, string sTel, string sMail)
        {
            Proveedor Obj = new Proveedor();
            Obj.Prov_Nombre = sNombre;
            Obj.Prov_Domicilio = sDomicilio;
            Obj.Prov_Departamento = sDepartamento;
            Obj.Prov_Codigo_Postal = sCP;
            Obj.Prov_Telefono = sTel;
            Obj.Prov_Email = sMail;

            return Obj.InsertProvider(Obj);
        }
        public static string EditProvider(int nID, string sNombre, string sDomicilio, string sDepartamento, string sCP, string sTel, string sMail)
        {
            Proveedor Obj = new Proveedor();
            Obj.Prov_Id = nID;
            Obj.Prov_Nombre = sNombre;
            Obj.Prov_Domicilio = sDomicilio;
            Obj.Prov_Departamento = sDepartamento;
            Obj.Prov_Codigo_Postal = sCP;
            Obj.Prov_Telefono = sTel;
            Obj.Prov_Email = sMail;

            return Obj.UpdateProvider(Obj);
        }
        public static string DeleteProvider(int nID)
        {
            Proveedor Obj = new Proveedor();
            Obj.Prov_Id = nID;
            return Obj.DeleteProvider(Obj);
        }
        public static DataTable SearchProvider(string sPattern)
        {
            Proveedor Obj = new Proveedor();
            Obj.Txt_Buscar = sPattern;
            return Obj.SearchProviders(Obj);
        }
        public static DataTable ViewProvider()
        {
            return new Proveedor().ListProviders();
        }
        public static DataTable OrderProvider()
        {
            return new Proveedor().OrderProviders();
        }
    }
}
