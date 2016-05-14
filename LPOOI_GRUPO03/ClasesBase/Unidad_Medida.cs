using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Unidad_Medida
    {
        private string uM_Abrev;

        public string UM_Abrev
        {
            get { return uM_Abrev; }
            set { uM_Abrev = value; }
        }
        private string uM_Descrip;

        public string UM_Descrip
        {
            get { return uM_Descrip; }
            set { uM_Descrip = value; }
        }
        private int uM_Id;

        public int UM_Id
        {
            get { return uM_Id; }
            set { uM_Id = value; }
        }
    }
}
