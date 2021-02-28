using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface ISlikaService
    {

        IEnumerable<Slika> GetSlike();
        Slika GetSlika(int id);
        void InsertSlika(Slika slika);
        void DeleteSlika(Slika slika);
        void SaveChanges(Slika slika);
    }
}
