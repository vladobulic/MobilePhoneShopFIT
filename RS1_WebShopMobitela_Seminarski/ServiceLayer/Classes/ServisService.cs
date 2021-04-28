using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class ServisService : IServisService
    {
        private IRepository<Servis> servisRepository;

        public ServisService(IRepository<Servis> servisRepository)
        {
            this.servisRepository = servisRepository;
        }

        public void DeleteServis(Servis servis)
        {
            servisRepository.Delete(servis);
        }

        public Servis GetServis(int id)
        {
            return servisRepository.Get(id);
        }

        public IEnumerable<Servis> GetServisi()
        {
            return servisRepository.GetAll();
        }
        public void InsertServis(Servis entity)
        {
            servisRepository.Insert(entity);
        }

        public void SaveChanges(Servis servis)
        {
            servisRepository.SaveChanges(servis);
        }
    }
}
