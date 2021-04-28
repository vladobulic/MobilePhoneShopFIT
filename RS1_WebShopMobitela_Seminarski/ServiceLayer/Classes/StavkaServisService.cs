using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class StavkaServisService : IStavkaServisService
    {
        private IRepository<StavkaServisa> stavkaRepository;

        public StavkaServisService(IRepository<StavkaServisa> stavkaRepository)
        {
            this.stavkaRepository = stavkaRepository;
        }

        public void DeleteStavka(StavkaServisa stavka)
        {
            stavkaRepository.Delete(stavka);
        }

        public StavkaServisa GetStavka(int id)
        {
            return stavkaRepository.Get(id);
        }

        public IEnumerable<StavkaServisa> GetStavke()
        {
            return stavkaRepository.GetAll();
        }
        public void InsertStavka(StavkaServisa entity)
        {
            stavkaRepository.Insert(entity);
        }

        public void SaveChanges(StavkaServisa stavka)
        {
            stavkaRepository.SaveChanges(stavka);
        }
    }
}
