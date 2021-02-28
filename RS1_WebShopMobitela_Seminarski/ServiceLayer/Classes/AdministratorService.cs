using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class AdministratorService : IAdministratorService
    {
        private IRepository<Administrator> adminRepository;

        public AdministratorService(IRepository<Administrator> adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        public void DeleteAdmin(Administrator admin)
        {
            adminRepository.Delete(admin);
        }

        public Administrator GetAdmin(int id)
        {
            return adminRepository.Get(id);
        }

        public IEnumerable<Administrator> GetAdmini()
        {
            return adminRepository.GetAll();
        }
        public void InsertAdmin(Administrator admin)
        {
            adminRepository.Insert(admin);
        }

        public void SaveChanges(Administrator admin)
        {
            adminRepository.SaveChanges(admin);
        }
    }
}
