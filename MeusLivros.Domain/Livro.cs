using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivros.Domain
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        //public int EditoraId { get; set; }
        //public virtual Editora Editora { get; set; } = new Editora();
        public string Status { get; set; } = string.Empty;
    }
}
