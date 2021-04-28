using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer
{
    public class ZaposlenikService : IZaposlenikService
    {
        private IRepository<Zaposlenik> zaposlenikRepository;

        public ZaposlenikService(IRepository<Zaposlenik> zaposlenikRepository)
        {
            this.zaposlenikRepository = zaposlenikRepository;
        }

        public void DeleteZaposlenik(Zaposlenik zaposlenik)
        {
            zaposlenikRepository.Delete(zaposlenik);
        }

        public Zaposlenik GetZaposlenik(int id)
        {
            return zaposlenikRepository.Get(id);
        }
        public int GetZaposlenikByAspUserId(string userId)
        {
            return zaposlenikRepository.GetAllQueryable().FirstOrDefault(x => x.ApplicationUser.Id == userId)?.Id ?? 0;
        }

        //public Zaposlenik GetZaposlenikById()
        // {
        //     return zaposlenikRepository.ge
        // }

        public IEnumerable<Zaposlenik> GetZaposlenici()
        {
            return zaposlenikRepository.GetAllQueryable();
        }
        public void InsertZaposlenik(Zaposlenik zaposlenik)
        {
            zaposlenikRepository.Insert(zaposlenik);
        }

        public void SaveChanges(Zaposlenik zaposlenik)
        {
            zaposlenikRepository.SaveChanges(zaposlenik);
        }
    }
}
