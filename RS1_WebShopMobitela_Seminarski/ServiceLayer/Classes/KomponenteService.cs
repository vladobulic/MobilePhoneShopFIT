using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Classes
{
    public class KomponenteService : IKomponenteService
    {
        IRepository<Komponente> komponenteRepository;

        public KomponenteService(IRepository<Komponente> komponenteRepository)
        {
            this.komponenteRepository = komponenteRepository;
        }

        public void DeleteKomponenta(Komponente komponente)
        {
            komponenteRepository.Delete(komponente);
        }

        public Komponente Get(int id)
        {
            return komponenteRepository.Get(id);
        }

        public IEnumerable<Komponente> GetKomponente()
        {
            return komponenteRepository.GetAll();
        }

        public void InsertKomponenta(Komponente komponente)
        {
            komponenteRepository.Insert(komponente);
        }

        public void SaveChanges(Komponente komponente)
        {
            komponenteRepository.SaveChanges(komponente);
        }
    }
}
