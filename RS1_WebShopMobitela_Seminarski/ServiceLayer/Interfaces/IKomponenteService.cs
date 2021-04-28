using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IKomponenteService
    {
        IEnumerable<Komponente> GetKomponente();
        Komponente Get(int id);
        void InsertKomponenta(Komponente komponente);
        void DeleteKomponenta(Komponente komponente);
        void SaveChanges(Komponente komponente);
    }
}
