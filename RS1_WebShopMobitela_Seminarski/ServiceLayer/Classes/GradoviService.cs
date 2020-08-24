using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class GradoviService : IGradoviService
    {
        private IRepository<Grad> gradRepository;

        public GradoviService(IRepository<Grad> gradRepository)
        {
            this.gradRepository = gradRepository;
        }

        public void DeleteGrad(Grad grad)
        {
            gradRepository.Delete(grad);
        }

        public Grad GetGrad(int id)
        {
            return gradRepository.Get(id);
        }

        public IEnumerable<Grad> GetGradovi()
        {
            return gradRepository.GetAll();
        }
        public void InsertGrad(Grad entity)
        {
            gradRepository.Insert(entity);
        }

        public void SaveChanges(Grad grad)
        {
            gradRepository.SaveChanges(grad);
        }
    }
}
