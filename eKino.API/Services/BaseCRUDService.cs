using AutoMapper;
using eKino.API.EF;
using eKino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> 
        : 
        BaseService<TModel, TSearch, TDatabase>, 
        ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual Korisnik Authenticate(KorisnikLoginRequest request)
        {
            throw new NotImplementedException();
        }

        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);

            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual bool Remove(int id)
        {
            var x = _context.Set<TDatabase>().Find(id); 
            if(x != null)
            {
                _context.Set<TDatabase>().Remove(x);
                return true;
            }
            return false;
        }

        public virtual TModel Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

    }
}
