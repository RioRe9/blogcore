using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogcore.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        ICategoriaRepository Categoria { get; }
        IArticuloRepository Articulo { get; }
        ISliderRepository Slider { get; }
        IUsuarioRepository Usuario { get; }
        void Save();
    }
}
