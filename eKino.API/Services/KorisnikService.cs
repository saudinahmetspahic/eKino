using AutoMapper;
using eKino.API.Database;
using eKino.API.EF;
using eKino.Model;
using eKino.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class KorisnikService 
        :
        BaseCRUDService<Model.Korisnik, KorisnikSearchRequest, Database.Korisnik, KorisnikInsertRequest, KorisnikInsertRequest>,
        IKorisnikService
    {
      
        public KorisnikService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }


        public void Add(KorisnikInsertRequest korisnik)
        {
            var k = _mapper.Map<Database.Korisnik>(korisnik);

            if(korisnik.Password != korisnik.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            k.LozinkaSalt = GenerateSalt();
            k.LozinkaHash = GenerateHash(k.LozinkaSalt, korisnik.Password);

            _context.Korisnik.Add(k);
            _context.SaveChanges();
        }

        public override Model.Korisnik Authenticate(KorisnikLoginRequest request)
        {
            var korisnik = _context.Korisnik.Include(i => i.Uloga).FirstOrDefault(x => x.Email == request.Email);

            if (korisnik != null)
            {
                var newHash = GenerateHash(korisnik.LozinkaSalt, request.Password);

                if (newHash == korisnik.LozinkaHash)
                {
                    Model.Korisnik user = _mapper.Map<Model.Korisnik>(korisnik);
                    return user;
                }
            }
            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public override List<Model.Korisnik> Get(KorisnikSearchRequest request)
        {
            var query = _context.Korisnik.AsQueryable();

            if(!string.IsNullOrEmpty(request?.Email))
            {
                query = query.Where(w => w.Email == request.Email);
            }

            var result = query.ToList();
            return _mapper.Map<List<Model.Korisnik>>(result);
        }

        //public Model.Korisnik GetById(int id)
        //{
        //    return _mapper.Map<Model.Korisnik>(_context.Korisnik.SingleOrDefault(w => w.Id == id));
        //}

        public Model.Korisnik GetByEmail(string email)
        {
            return _mapper.Map<Model.Korisnik>(_context.Korisnik.SingleOrDefault(w => w.Email == email));
        }

        public Model.Korisnik GetByIme(string ime)
        {
            return _mapper.Map<Model.Korisnik>(_context.Korisnik.SingleOrDefault(w => w.Ime == ime));
        }

        public Model.Korisnik GetByPrezime(string prezime)
        {
            return _mapper.Map<Model.Korisnik>(_context.Korisnik.SingleOrDefault(w => w.Prezime == prezime));
        }

        //public bool Remove(int id)
        //{
        //    var korisnik = _context.Korisnik.SingleOrDefault(w => w.Id == id);
        //    if(korisnik != null)
        //    {
        //        _context.Korisnik.Remove(korisnik);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}

        public override Model.Korisnik Update(int id, KorisnikInsertRequest korisnik)
        {
            var k = _context.Korisnik.SingleOrDefault(w => w.Id == id);
            if (k != null)
            {
                if (!string.IsNullOrEmpty(korisnik.Password))
                {
                    var salt = GenerateSalt();
                    var hash = GenerateHash(salt, korisnik.Password);
                    k.LozinkaSalt = salt;
                    k.LozinkaHash = hash;
                }
                k.Ime = korisnik.Ime;
                k.Prezime = korisnik.Prezime;
                k.Email = korisnik.Email;
                k.GradId = korisnik.GradId;
                k.UlogaId = korisnik.UlogaId;
                k.DatumRodjenja = korisnik.DatumRodjenja;
                _context.Korisnik.Update(k);
                _context.SaveChanges();
            }
            return _mapper.Map<Model.Korisnik>(k);
        }

    }
}
