using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface INarudzbaService
    {
        void InsertNarudzba(Narudzba narudzba, List<StavkaNarudzbe> stavke);
        List<Narudzba> GetNarudzbe(string userId);
    }
}
