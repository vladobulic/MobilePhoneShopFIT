using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IBannedKupacService
    {
        IEnumerable<BannedKupac> GetBannedKupci();
        BannedKupac GetBannedKupac(int id);

        void InsertBannedKupac(BannedKupac kupac);
        
    }
}
