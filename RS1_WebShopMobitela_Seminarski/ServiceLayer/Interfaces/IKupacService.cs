using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IKupacService
    {
        IEnumerable<Kupac> GetKupci();
        Kupac GetKupac(int id);

        void InsertKupac(Kupac kupac);
        int GetKupacByAspUserId(string userId);
    }
}
