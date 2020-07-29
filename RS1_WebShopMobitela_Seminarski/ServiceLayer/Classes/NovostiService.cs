using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Classes
{
    public class NovostiService : INovostiService
    {
        private IRepository<Novosti> novostiRepository;
        public NovostiService(IRepository<Novosti> novostiRepository)
        {
            this.novostiRepository = novostiRepository;
        }

        public IEnumerable<Novosti> GetNovosti()
        {
            return novostiRepository.GetAllQueryable().OrderByDescending(x => x.Datum).ToList();
        }
    }
}
