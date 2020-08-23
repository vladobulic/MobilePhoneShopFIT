using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Classes
{
    public class PopustiService : IPopustiService
    {
        private IRepository<Popusti> popustiRepository;

        public PopustiService(IRepository<Popusti> popustiRepository)
        {
            this.popustiRepository = popustiRepository;
        }

        public Popusti Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Popusti> GetPopusti()
        {
            return popustiRepository.GetAllQueryable().OrderBy(x => x.Id).ToList();
        }
    }
}


