using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IStavkaServisService 
    {

        IEnumerable<StavkaServisa> GetStavke();
        StavkaServisa GetStavka(int id);
        void InsertStavka(StavkaServisa stavka);
        void DeleteStavka(StavkaServisa stavka);
        void SaveChanges(StavkaServisa stavka);
    }
}
