using MeusLivros.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivros.Service.Interface
{
    public interface ILivro
    {
        bool CreateLivro(Livro livro);
    }
}
