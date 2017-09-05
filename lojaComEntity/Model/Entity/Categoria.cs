using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Model.Entity
{
    public class Categoria
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public IList<Produto> produtos { get; set; }
    }
}
