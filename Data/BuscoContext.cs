using.System.collection.generic;

namespace pc3.Models
{
    public class categoria
    {
        public int id { get; set; }

        public string NombreCategorias { get; set; }

        public ICollection<Producto> Producto { get; set; }
    }
}
