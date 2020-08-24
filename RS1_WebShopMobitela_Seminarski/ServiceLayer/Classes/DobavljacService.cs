using Microsoft.AspNetCore.Mvc.Internal;
using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Classes
{
    public class DobavljacService : IDobavljacService
    {
        private IRepository<Dobavljac> dobavljacRepository;

        public DobavljacService(IRepository<Dobavljac> dobavljacRepository)
        {
            this.dobavljacRepository = dobavljacRepository;
        }

        public void DeleteDobavljac(Dobavljac dobavljac)
        {
            dobavljacRepository.Delete(dobavljac);
        }

        public Dobavljac GetDobavljac(int id)
        {
            return dobavljacRepository.Get(id);
        }

        public IEnumerable<Dobavljac> GetDobavljaci()
        {
            return dobavljacRepository.GetAll();
        }

        public void InsertDobavljac(Dobavljac dobavljac)
        {
            dobavljacRepository.Insert(dobavljac);
        }

        public void SaveChanges(Dobavljac dobavljac)
        {
            dobavljacRepository.SaveChanges(dobavljac);
        }
    }
}
