using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Classes
{
    public class StavkeNarudzbeService : IStavkeNarudzbeService
    {
        private IRepository<StavkaNarudzbe> stavkeNaruzbaRepository;

        public StavkeNarudzbeService(IRepository<StavkaNarudzbe> stavkeNaruzbaRepository)
        {
            this.stavkeNaruzbaRepository = stavkeNaruzbaRepository;
        }

        public void DeleteStavkaNarudzba(StavkaNarudzbe stavkaNarudzba)
        {
            throw new NotImplementedException();
        }

        public StavkaNarudzbe GetStavkaNarudzba(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StavkaNarudzbe> GetStavkeNarudzbe()
        {
            return stavkeNaruzbaRepository.GetAll();
        }

        public void SaveChanges(StavkaNarudzbe stavkaNarudzba)
        {
            throw new NotImplementedException();
        }
    }
}
