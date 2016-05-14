using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ClasesBase;

namespace ClaseConexion
{
    public class TrabajarFamilia
    {
        public static string InsertFamily(string sDescrip)
        {
            Familia Obj = new Familia();
            Obj.Fam_Descrip = sDescrip;
            return Obj.InsertFamily(Obj);
        }
        public static string EditFamily(int nFam, string sDescrip)
        {
            Familia Obj = new Familia();
            Obj.Fam_Id = nFam;
            Obj.Fam_Descrip = sDescrip;
            return Obj.UpdateFamily(Obj);
        }
        public static string DeleteFamily(int nID)
        {
            Familia Obj = new Familia();
            Obj.Fam_Id = nID;
            return Obj.DeleteFamily(Obj);
        }

        public static DataTable ViewFamilia()
        {
            return new Familia().ListFamilia();
        }
    }
}
