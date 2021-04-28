using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IGradoviService
    {

        IEnumerable<Grad> GetGradovi();
        Grad GetGrad(int id);
        void InsertGrad(Grad grad);
        void DeleteGrad(Grad grad);
        void SaveChanges(Grad grad);
    }
}
