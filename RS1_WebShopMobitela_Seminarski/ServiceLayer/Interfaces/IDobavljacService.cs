using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IDobavljacService
    {

        IEnumerable<Dobavljac> GetDobavljaci();
        Dobavljac GetDobavljac(int id);
        void InsertDobavljac(Dobavljac dobavljac);
        void DeleteDobavljac(Dobavljac dobavljac);
        void SaveChanges(Dobavljac dobavljac);
    }
}
