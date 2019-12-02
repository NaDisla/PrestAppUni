using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrestApp.Clases
{

    public class ClRoles
    {


        public int IdRol
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        /*public override string ToString()
        {
            return string.Format("{0} {1}", IDRol, Nombre);
        }*/
    }
}
