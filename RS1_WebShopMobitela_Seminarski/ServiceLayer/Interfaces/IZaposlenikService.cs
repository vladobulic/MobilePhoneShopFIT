using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IZaposlenikService
    {

        IEnumerable<Zaposlenik> GetZaposlenici();
        Zaposlenik GetZaposlenik(int id);
        void InsertZaposlenik(Zaposlenik zaposlenik);
        void DeleteZaposlenik(Zaposlenik zaposlenik);
        void SaveChanges(Zaposlenik zaposlenik);
        public int GetZaposlenikByAspUserId(string userId);
    }
}
