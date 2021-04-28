using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IServisService
    {

        IEnumerable<Servis> GetServisi();
        Servis GetServis(int id);
        void InsertServis(Servis servis);
        void DeleteServis(Servis servis);
        void SaveChanges(Servis servis);
    }
}
