using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Model.Databases
{
    internal class DAL<T> where T : class 
    {
        protected readonly ControleFinanceiroContext _context;

        public DAL(ControleFinanceiroContext context)
        {
            this._context = context;
        }

        public IEnumerable<T> ObterTodosOsRegistros() 
        {
            return _context.Set<T>().ToList();
        }

        public void Adicionar(T objeto)
        {
            _context.Set<T>().Add(objeto);
            _context.SaveChanges();
        }

        public void Atualizar(T objeto)
        {
            _context.Set<T>().Update(objeto);
            _context.SaveChanges();
        }

        public void Deletar(T objeto)
        {
            _context.Set<T>().Remove(objeto);
            _context.SaveChanges();
        }

        public T? RetornaPor(Func<T, bool> condicao)
        {
            return _context.Set<T>().FirstOrDefault(condicao);
        }

        public IEnumerable<T> RetornaListaPor(Func<T, bool> condicao)
        {
            return _context.Set<T>().Where(condicao).ToList();
        }

    }
}
