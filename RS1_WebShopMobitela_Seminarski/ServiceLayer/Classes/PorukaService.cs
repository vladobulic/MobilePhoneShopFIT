using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class PorukaService : IPorukaService
    {
        private IRepository<Poruka> porukaRepository;

        public PorukaService(IRepository<Poruka> porukaRepository)
        {
            this.porukaRepository = porukaRepository;
        }

        public void DeletePoruka(Poruka poruka)
        {
            porukaRepository.Delete(poruka);
        }

        public Poruka GetPoruka(int id)
        {
            return porukaRepository.Get(id);
        }

        public IEnumerable<Poruka> GetPoruke()
        {
            return porukaRepository.GetAll();
        }
        public void InsertPoruka(Poruka poruka)
        {
            porukaRepository.Insert(poruka);
        }

        public void SaveChanges(Poruka poruka)
        {
            porukaRepository.SaveChanges(poruka);
        }
    }
}
