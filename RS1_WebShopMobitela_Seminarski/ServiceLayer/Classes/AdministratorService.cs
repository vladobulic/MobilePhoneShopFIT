using DataAccessLayer;
using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public int GetAdminByAspUserId(string userId)
        {
            return adminRepository.GetAllQueryable().FirstOrDefault(x => x.ApplicationUser.Id == userId)?.Id ?? 0;
        }
        public IEnumerable<Administrator> GetAdmini()
        {
            return adminRepository.GetAllQueryable();
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
