using HotCatCafe.BLL.Abstracts.BaseAbstract.BaseRepository;
using HotCatCafe.DAL.Context;
using HotCatCafe.Model.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace HotCatCafe.BLL.Concretes.BaseService
{
    public class BaseService<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly HotCatCafeContext _cafeContext;
        private DbSet<T> _entities;

        public BaseService(HotCatCafeContext cafeContext)
        {
            _cafeContext = cafeContext;
            _entities = _cafeContext.Set<T>();

        }

        public Task<string> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<string> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetActives()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetPassives()
        {
            throw new NotImplementedException();
        }

        public Task<string> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
