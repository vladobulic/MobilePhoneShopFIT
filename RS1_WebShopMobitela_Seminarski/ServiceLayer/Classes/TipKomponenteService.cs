using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Classes
{
    public class TipKomponenteService : ITipKomponenteService
    {
        IRepository<TipKomponente> tipKomponenteRepository;

        public TipKomponenteService(IRepository<TipKomponente> tipKomponenteRepository)
        {
            this.tipKomponenteRepository = tipKomponenteRepository;
        }

        public void DeleteTipKomponenta(TipKomponente tipKomponente)
        {
            tipKomponenteRepository.Delete(tipKomponente);
        }

        public TipKomponente Get(int id)
        {
            return tipKomponenteRepository.Get(id);
        }

        public IEnumerable<TipKomponente> GetTipKomponente()
        {
            return tipKomponenteRepository.GetAll();
        }

        public void InsertTipKomponenta(TipKomponente tipKomponente)
        {
            tipKomponenteRepository.Insert(tipKomponente);
        }

        public void SaveChanges(TipKomponente tipKomponente)
        {
            tipKomponenteRepository.SaveChanges(tipKomponente);
        }
    }
}
