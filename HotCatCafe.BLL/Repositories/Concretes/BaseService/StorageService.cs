using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.BaseStorageService;
using HotCatCafe.DAL.Context;
using HotCatCafe.Model.BaseEntities;
using HotCatCafe.Model.Enums;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using System.Reflection;

namespace HotCatCafe.BLL.Repositories.Concretes.BaseService
{
    public class StorageService<T> : IStorageService<T> where T : BaseEntity
    {
        private readonly HotCatCafeContext _context;
        private DbSet<T> _entities;

        public StorageService(HotCatCafeContext cafeContext)
        {
            _context = cafeContext;
            _entities = _context.Set<T>();

        }

        public async Task<string> Create(T entity)
        {
            if (entity == null)
            {
                return "Entity cannot be null";
            }
            try
            {
                entity.Status = DataStatus.Inserted;
                await _entities.AddAsync(entity);
                await _context.SaveChangesAsync();

                return "Registration successful";

            }
            catch (Exception ex)
            {

                return "Error occurred while saving to database" + ex.Message;
            }
        }

        public async Task<string> Delete(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null");

            }
            try
            {
                //todo: numu araştır
                PropertyInfo isActiveProp = entity.GetType().GetProperty("IsActive");
                if (isActiveProp != null && isActiveProp.PropertyType == typeof(bool))
                {
                    isActiveProp.SetValue(entity, false);
                }

                // Assuming DataStatus.Deleted is an enum value you set for marking as deleted
                entity.Status = DataStatus.Deleted;

                Update(entity);

                return "Entity deleted successfully";
            }
            catch (Exception ex)
            {

                return "Error occured while deleting entity in database" + ex.Message;
            }
        }
        public async Task<string> Update(T entity)
        {
            string result = " ";
            try
            {
                switch (entity.Status)
                {
                    case Model.Enums.DataStatus.Deleted:
                        entity.Status = DataStatus.Deleted;

                        //_context.Entry(entity).State = EntityState.Modified;//EntityFramework ile birlikte bize sunulan Entry() metot paramaternin değerlerini veritabanındaki değerler ile otomatik olarak karşılaştırır eğer değişiklik görürse o değişikliği kendisi otomatik gerçekleştirir.

                        //await _context.SaveChangesAsync();//değişiklikler veri tabanına kayıt edilir
                        result = "Data deleted";

                        break;

                    case DataStatus.Updated:
                        entity.Status = DataStatus.Updated;

                        result = "Data updated";
                        break;

                    case Model.Enums.DataStatus.Inserted:
                        entity.Status = DataStatus.Updated;
                        result = "Data inserted";

                        break;
                    
                }
                _context.Entry(entity).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                return $"Error occured while updating enttiy:{ex.Message}";
            }
            return result;
        }

        public IEnumerable<T> GetActives()
        {
            return _context.Set<T>().Where(x => x.IsActive).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();//tolist ile LINQ sorgusu sonucunda varlıkların veritabanından alınarak belleğe alınmasını sağlamış oluyoruz.
        }

        public T GetById(int id)
        {

            try
            {
                return _entities.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetPassives()
        {
            return _context.Set<T>().Where(x => !x.IsActive).ToList();
        }


    }
}
