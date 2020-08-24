using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class ZupanijaService : IZupanijaService
    {
        private IRepository<Zupanija> zupanijaRepository;

        public ZupanijaService(IRepository<Zupanija> zupanijaRepository)
        {
            this.zupanijaRepository = zupanijaRepository;
        }

        public void DeleteZupanija(Zupanija zupanija)
        {
            zupanijaRepository.Delete(zupanija);
        }

        public Zupanija GetZupanija(int id)
        {
            return zupanijaRepository.Get(id);
        }

        public IEnumerable<Zupanija> GetZupanije()
        {
            return zupanijaRepository.GetAll();
        }

        public void InsertZupanija(Zupanija zupanija)
        {
            zupanijaRepository.Insert(zupanija);
        }

        public void SaveChanges(Zupanija zup)
        {
            zupanijaRepository.SaveChanges(zup);
        }
    }
}
