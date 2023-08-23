using blogcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace blogcore.AccesoDatos.Data.Repository.IRepository
{
    public interface IArticuloRepository : IRepository<Articulo>
    {

        void Update(Articulo articulo);
    }
}
