using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface ITipKomponenteService
    {
        IEnumerable<TipKomponente> GetTipKomponente();
        TipKomponente Get(int id);
        void InsertTipKomponenta(TipKomponente tipKomponente);
        void DeleteTipKomponenta(TipKomponente tipKomponente);
        void SaveChanges(TipKomponente tipKomponente);
    }
}
