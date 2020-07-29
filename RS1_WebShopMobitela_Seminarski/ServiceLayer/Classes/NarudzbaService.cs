using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Classes
{
    public class NarudzbaService : INarudzbaService
    {
        private IRepository<Narudzba> naruzbaRepository;
        private IRepository<StavkaNarudzbe> stavkeNaruzbaRepository;

        public NarudzbaService(IRepository<Narudzba> naruzbaRepository, IRepository<StavkaNarudzbe> stavkeNaruzbaRepository)
        {
            this.naruzbaRepository = naruzbaRepository;
            this.stavkeNaruzbaRepository = stavkeNaruzbaRepository;
        }

        public List<Narudzba> GetNarudzbe(string userId)
        {
            return naruzbaRepository.GetAllQueryable().Where(x => x.Kupac.ApplicationUser.Id == userId).OrderByDescending( x=>x.Datum).ToList();
        }


        public void InsertNarudzba(Narudzba narudzba, List<StavkaNarudzbe> stavke)
        {
            int id = naruzbaRepository.InsertAndReturnEntityId(narudzba);
            stavke.ForEach(x => x.NarudzbaId = id);
            stavkeNaruzbaRepository.InsertRange(stavke);
        }
    }
}
