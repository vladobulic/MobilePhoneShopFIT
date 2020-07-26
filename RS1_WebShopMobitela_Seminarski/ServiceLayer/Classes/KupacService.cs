using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Classes
{
    public class KupacService : IKupacService
    {
        private IRepository<Kupac> kupacRepository;

        public KupacService(IRepository<Kupac> kupacRepository)
        {
            this.kupacRepository = kupacRepository;
        }

        public Kupac GetKupac(int id)
        {
            return kupacRepository.Get(id);
        }

        public IEnumerable<Kupac> GetKupci()
        {
            return kupacRepository.GetAll();
        }

        public void InsertKupac(Kupac kupac)
        {
            kupacRepository.Insert(kupac);
        }
    }
}
