using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Industria.Domain.Entities.Interfaces
{
   public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        void Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity obj);
        void Remover(int id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}