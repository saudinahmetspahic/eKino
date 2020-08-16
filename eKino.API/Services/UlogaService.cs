using AutoMapper;
using eKino.API.EF;
using eKino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class UlogaService : IUlogaService
    {
        private readonly MojContext _context = null;
        private readonly IMapper _mapper = null;

        public UlogaService(MojContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Uloga> Get()
        {
            return _mapper.Map<List<Model.Uloga>>(_context.Uloga.ToList());
        }

        public Model.Uloga GetByName(string name)
        {
            var u = _context.Uloga.SingleOrDefault(w => w.NazivUloge == name);
            return _mapper.Map<Model.Uloga>(u);
        }

        public Model.Uloga GetById(int Id)
        {
            var u = _context.Uloga.SingleOrDefault(w => w.Id == Id);
            return _mapper.Map<Model.Uloga>(u);
        }
    }
}
