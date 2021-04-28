using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IPorukaService
    {

        IEnumerable<Poruka> GetPoruke();
        Poruka GetPoruka(int id);
        void InsertPoruka(Poruka poruka);
        void DeletePoruka(Poruka poruka);
        void SaveChanges(Poruka poruka);
    }
}
