using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IZupanijaService
    {

        IEnumerable<Zupanija> GetZupanije();
        Zupanija GetZupanija(int id);
        void InsertZupanija(Zupanija zupanija);
        void DeleteZupanija(Zupanija zupanija);
        void SaveChanges(Zupanija zup);
    }
}
