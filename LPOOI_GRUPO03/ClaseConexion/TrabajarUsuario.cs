using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ClasesBase;

namespace ClaseConexion
{
    public class TrabajarUsuario
    {
        public static string InsertUser(int nRol, string sApellido, string sNombre,string sUsuario,string sPass, string sEmail)
        {
            Usuario Obj = new Usuario();
            Obj.Rol_Id = nRol;
            Obj.Usr_Apellido = sApellido;
            Obj.Usr_Nombre = sNombre;
            Obj.Usr_UserName = sUsuario;
            Obj.Usr_Password = sPass;
            Obj.Usr_Email = sEmail;
            
            return Obj.InsertUser(Obj);
        }
        public static string EditUser(int nUser, string sApellido, string sNombre,string sUsuario,string sPass, string sEmail,int nRol)
        {
            Usuario Obj = new Usuario();
            Obj.Usr_Id = nUser;
            Obj.Usr_Apellido = sApellido;
            Obj.Usr_Nombre = sNombre;
            Obj.Usr_UserName = sUsuario;
            Obj.Usr_Password = sPass;
            Obj.Usr_Email = sEmail;
            Obj.Rol_Id = nRol;
            return Obj.UpdateUser(Obj);
        }
        public static string DeleteUser(int nID)
        {
            Usuario Obj = new Usuario();
            Obj.Usr_Id = nID;
            return Obj.DeleteUser(Obj);
        }
        public static DataTable SearchUser(string sPattern)
        {
            Usuario Obj = new Usuario();
            Obj.Txt_Buscar = sPattern;
            return Obj.SearchUsers(Obj);
        }
        public static DataTable ViewUser()
        {
            return new Usuario().ListUsers();
        }
        public static DataTable ViewRol()
        {
            return new Usuario().ListRols();
        }

        public static DataTable LogIn(string sUser, string sPass)
        {
            Usuario Obj = new Usuario();
            Obj.Usr_UserName = sUser;
            Obj.Usr_Password = sPass;
            return Obj.ValidUser(Obj);
        }
    }
}