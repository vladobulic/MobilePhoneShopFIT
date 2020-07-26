using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IGradoviService
    {

        IEnumerable<Grad> GetGradovi();
        Grad GetGrad(int id);
    }
}
