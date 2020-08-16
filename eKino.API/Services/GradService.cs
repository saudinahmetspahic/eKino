using AutoMapper;
using eKino.API.Database;
using eKino.API.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class GradService : IGradService
    {
        private readonly MojContext _context = null;
        private readonly IMapper _mapper = null;
        public GradService(MojContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(Model.Grad grad)
        {
            _context.Grad.Add(_mapper.Map<Database.Grad>(grad));
            _context.SaveChanges();
        }

        public List<Model.Grad> Get()
        {
            return _mapper.Map<List<Model.Grad>>(_context.Grad.ToList());
        }

        public Model.Grad GetById(int id)
        {
            return _mapper.Map<Model.Grad>(_context.Grad.SingleOrDefault(w => w.Id == id));
        }

        public Model.Grad GetByNaziv(string naziv)
        {
            return _mapper.Map<Model.Grad>(_context.Grad.SingleOrDefault(w => w.Naziv == naziv));
        }

        public bool Remove(int id)
        {
            var grad = _context.Grad.SingleOrDefault(w => w.Id == id);
            if(grad != null)
            {
                _context.Grad.Remove(grad);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Model.Grad Update(int id, Model.Grad grad)
        {
            var g = _context.Grad.SingleOrDefault(w => w.Id == id);
            if(g != null)
            {
                g = _mapper.Map<Database.Grad>(grad);
                _context.SaveChanges();
                return _mapper.Map<Model.Grad>(g);
            }
            return grad;
        }
    }
}
