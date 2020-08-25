using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface INarudzbaService
    {
        void InsertNarudzba(Narudzba narudzba, List<StavkaNarudzbe> stavke);
        List<Narudzba> GetNarudzbe(string userId);



        IEnumerable<Narudzba> GetNarudzbe2();
        Narudzba GetNarudzba(int id);
        void DeleteNarudzba(Narudzba narudzba);
        void SaveChanges(Narudzba narudzba);
    }
}
