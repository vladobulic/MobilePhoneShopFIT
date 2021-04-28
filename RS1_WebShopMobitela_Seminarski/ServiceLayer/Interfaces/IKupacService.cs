using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IKupacService
    {
        IQueryable<Kupac> GetKupci();
        Kupac GetKupac(int id);

        void InsertKupac(Kupac kupac);
        int GetKupacByAspUserId(string userId);

        public void SaveChanges(Kupac kupac);
    }
}
