using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IStavkeNarudzbeService
    {
        



        IEnumerable<StavkaNarudzbe> GetStavkeNarudzbe();
        StavkaNarudzbe GetStavkaNarudzba(int id);
        void DeleteStavkaNarudzba(StavkaNarudzbe stavkaNarudzba);
        void SaveChanges(StavkaNarudzbe stavkaNarudzba);
    }
}
