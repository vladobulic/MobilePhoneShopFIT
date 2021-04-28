using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IKomentarService
    {
        List<Komentar> GetAllKomentariByPhoneId(int id);
        Komentar GetKomentar(int id);
        IEnumerable<Komentar> GetKomentari();
        void InsertKomentar(Komentar komentar);
        public void DeleteKomentar(Komentar komentar);
        void SaveChanges(Komentar komentar);
    }
}
