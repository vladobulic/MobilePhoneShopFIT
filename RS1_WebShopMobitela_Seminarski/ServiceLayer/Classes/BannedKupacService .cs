using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Classes
{
    public class BannedKupacService : IBannedKupacService
    {
        private IRepository<BannedKupac> bannedKupacRepository;

        public BannedKupacService(IRepository<BannedKupac> bannedKupacRepository)
        {
            this.bannedKupacRepository = bannedKupacRepository;
        }

        public BannedKupac GetBannedKupac(int id)
        {
            return bannedKupacRepository.Get(id);
        }

        

        public IEnumerable<BannedKupac> GetBannedKupci()
        {
            return bannedKupacRepository.GetAll();
        }

        public void InsertBannedKupac(BannedKupac kupac)
        {
            bannedKupacRepository.Insert(kupac);
        }
    }
}
