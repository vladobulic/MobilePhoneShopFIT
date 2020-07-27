using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IProizvodjacService
    {
        IEnumerable<Proizvodjac> GetProizvodjaci();
        Proizvodjac Get(int id);
    }
}
