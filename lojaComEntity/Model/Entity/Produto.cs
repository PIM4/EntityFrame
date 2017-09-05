using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Model.Entity
{
    public class Produto
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public float preco { get; set; }
        public virtual Categoria categoria { get; set; }
        public int categoriaID { get; set; }
    }
}
