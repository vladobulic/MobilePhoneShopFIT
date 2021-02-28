using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IAdministratorService
    {

        IEnumerable<Administrator> GetAdmini();
        Administrator GetAdmin(int id);
        void InsertAdmin(Administrator admin);
        void DeleteAdmin(Administrator admin);
        void SaveChanges(Administrator admin);
    }
}
