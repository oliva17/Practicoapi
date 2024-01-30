using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiAplicacion.Models;

namespace apiAplicacion.Business.Contracts
{

    public interface IRolRepository
    {
        Task<List<Rol>> GetList();
        Task<Rol> AgregaActualiza(Rol l, string t);
    }
}