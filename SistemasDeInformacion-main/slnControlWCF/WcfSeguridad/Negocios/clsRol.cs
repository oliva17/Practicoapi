using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using WcfSeguridad.Entidades;
using WcfSeguridad.Datos;

namespace WcfSeguridad.Negocios
{

    public class clsRol : clsRolDA
    {
        public clsRol()
        {
            this.IdRol = 0;
            this.NombreRol = string.Empty;         
        }

        public clsRol(int IdRol)
        {
        }


        public clsRol clsRolPorIdRol()
        {
            using (IDataReader dr = ObtieneRol(this))
            {
                if (dr.Read())
                {
                    this.IdRol = Convert.ToInt32(dr["IdRol"]);
                    this.NombreRol = Convert.ToString(dr["NombreRol"]);                    
                }
            }
            return this;
        }

        public int AgregaRol()
        {
            clsRolDA ad = new clsRolDA();
            return ad.AgregaRol(this);
        }

        public int ModificaRol()
        {
            clsRolDA ad = new clsRolDA();
            return ad.ModificaRol(this);
        }

        public int EliminaRol()
        {
            clsRolDA ad = new clsRolDA();
            return ad.EliminaRol(this);
        }

    }
}
