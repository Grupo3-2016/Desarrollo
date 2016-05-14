using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Roles
    {
        private int rol_Id;
        private string rol_Descrip;

        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }
        public string Rol_Descrip
        {
            get { return rol_Descrip; }
            set { rol_Descrip = value; }
        }
        
        //Constructors
        public Roles()
        {
        }
        public Roles(int nID,string sDescrip)
        {
            Rol_Id = nID;
            Rol_Descrip = sDescrip;
        }
    }
}
