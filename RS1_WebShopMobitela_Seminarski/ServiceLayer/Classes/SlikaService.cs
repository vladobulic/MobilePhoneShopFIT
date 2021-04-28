using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class SlikaService : ISlikaService
    {
        private IRepository<Slika> slikaRepository;

        public SlikaService(IRepository<Slika> slikaRepository)
        {
            this.slikaRepository = slikaRepository;
        }

        public void DeleteSlika(Slika slika)
        {
            slikaRepository.Delete(slika);
        }

        public Slika GetSlika(int id)
        {
            return slikaRepository.Get(id);
        }

        public IEnumerable<Slika> GetSlike()
        {
            return slikaRepository.GetAll();
        }
        public void InsertSlika(Slika entity)
        {
            slikaRepository.Insert(entity);
        }

        public void SaveChanges(Slika slika)
        {
            slikaRepository.SaveChanges(slika);
        }
    }
}
